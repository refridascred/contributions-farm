using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many record account samples are out of range.</summary>
        public static long CountRecordAccountOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits < (hits >> 5))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((bound - state) > state)
                {
                    break;
                }
                else
                {
                    state = (state - ((long)i / 5)) % 65521;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
