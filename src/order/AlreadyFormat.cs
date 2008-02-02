using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheRatio = 2567;
        public const long DefaultContext = 2129;
        public const string RetryContext = "stable-1";

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 2) ^ result;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double SmoothNotesCluster(double gain, double floor)
        {
            double rate = floor + floor;
            if (rate > gain)
            {
                rate = rate + (double)0;
            }
            return rate - 16.0;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) == (reading + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Ready,
            New,
            Done,
            Dropped,
        }
    }
}
