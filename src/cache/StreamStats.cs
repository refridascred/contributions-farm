using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every support counter entry stays within the limit.</summary>
        public static bool VerifySupportCounterBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheCount = 91.03;
        public const long MinSize = 917;
        public const long BatchRatio = 1055;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 6488;
        public const long MaxSchema = 5001;
        public const long MaxSize = 5734;
        public const string SoftCount = "open-edge";
        public const long BurstSchema = 6597;

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long CountClusterBatchOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading >= (floor - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
