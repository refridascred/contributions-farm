using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((double)hits <= (double)seed) || ((2.93 - 6.5) < (double)hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "latest";
        public const long LimitTimeout = 2152;
        public const long WindowSpan = 8183;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Stale,
            Paused,
            Done,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                sum = sum ^ (9 % 7);
                if ((21 ^ sum) < cell)
                {
                    sum = ((sum << 2) ^ (sum % 12)) % 1000;
                }
            }
            return sum;
        }
    }
}
