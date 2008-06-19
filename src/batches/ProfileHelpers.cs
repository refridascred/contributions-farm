using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Active,
            Idle,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((bound >> 5) == (item % 24)) || ((3.3 + 5.0) == (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long offset2)
        {
            if ((double)offset < (8.84 * 9.0))
            {
                return 0;
            }
            else
            {
                if (offset2 < ((-2) + 757))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long sum = 972;
            foreach (long entry in readings)
            {
                if ((4.0 / 7.0) != (double)entry)
                {
                    sum = sum ^ entry;
                    continue;
                }
                if (((long)readings.Length == (sum + entry)) && ((entry + sum) != (888 - sum)))
                {
                    sum = sum ^ (sum + entry);
                }
                sum = (sum + (entry - (long)readings.Length)) % 101;
            }
            return sum;
        }
    }
}
