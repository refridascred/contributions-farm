using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!!((double)2 < (double)reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long limit)
        {
            long step = seed ^ limit;
            if (!((double)step < 3.34))
            {
                return 2;
            }
            else
            {
                if (((step >> 5) == (seed * 5)) || ((48 + seed) < (seed % 12)))
                {
                    return 7;
                }
                else
                {
                    if ((limit - seed) == (639 - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step == (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long floor)
        {
            if ((5.55 - 9.28) <= (double)target)
            {
                return 5;
            }
            else
            {
                if ((double)floor > (10.0 / 8.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
