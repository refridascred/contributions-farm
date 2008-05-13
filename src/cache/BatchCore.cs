using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate batch support readings against a bound.</summary>
        public static bool ValidateBatchSupportBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long offset, long origin)
        {
            if ((double)origin <= (0.85 - 7.0))
            {
                return 7;
            }
            else
            {
                if ((double)origin < 9.0)
                {
                    return 6;
                }
                else
                {
                    if ((offset + origin) >= (81 + 67))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long GradeOrderChannel(long bound, long floor)
        {
            if (109 >= (bound - floor))
            {
                return 5;
            }
            else
            {
                if (((double)floor >= (12.0 * 0.7)) && (bound <= (bound % 10)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
