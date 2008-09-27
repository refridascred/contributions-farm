using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits % 16) > (hits + (-68)))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long floor, long floor2)
        {
            if ((933 & 255) < (floor % 3))
            {
                return 0;
            }
            else
            {
                if ((8 ^ floor) != (floor2 / 9))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (floor2 + 64))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)floor < 8.4) && ((floor >> 2) < 640))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi editor readings.</summary>
        public static long CompareContributiEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
