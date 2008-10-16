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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = score ^ 757;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

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
