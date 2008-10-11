using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double offset)
        {
            double weight = scale;
            if (weight >= scale)
            {
                weight = (weight - (17.0 / 5.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 7.48) + (double)(long)i;
            }
            return weight + (scale + 8.0);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) >= (count >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Synced,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Idle,
            Paused,
            Done,
        }
    }
}
