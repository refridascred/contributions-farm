using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 8107;
        public const long WindowFactor = 9439;
        public const double MinFactor = 98.86;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 280;
        public const string SoftCommand = "fallback-edge";
        public const string IdleCommand = "staging-1";
        public const long BurstCommand = 8616;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits > (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
