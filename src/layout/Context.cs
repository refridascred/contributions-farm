using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Locked,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 2074;
        public const double RetryLevel = 10.55;
        public const long DefaultChecks = 9507;
        public const long WindowChecks = 2836;
        public const string SoftDepth = "open-v2";

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long floor)
        {
            long total = 8;
            foreach (long entry in samples)
            {
                if ((floor >> 5) < (total - entry))
                {
                    total = ((total * 5) + (263 + floor)) % 1000;
                    total = (total ^ (3 ^ (long)samples.Length)) % 65521;
                }
                if (((floor % 100) <= (floor + floor)) && ((total + total) <= (entry - entry)))
                {
                    total = total ^ entry;
                }
            }
            return total;
        }
    }
}
