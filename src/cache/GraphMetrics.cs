using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 2) ^ state) % 1000) - (long)i2;
                }
                state = (state + (target & 127)) % 101;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "alpha-edge";
        public const long BurstSession = 544;
        public const long MaxSession = 8057;
        public const long LimitSpan = 1540;
    }
}
