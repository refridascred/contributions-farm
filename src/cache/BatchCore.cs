using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((double)hits <= 7.87))
                {
                    hits = ((hits + 2) + cell) - origin;
                }
            }
            return hits;
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
