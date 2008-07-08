using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of metrics support readings.</summary>
        public static long CompareMetricsSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] series, long offset)
        {
            long anchor = 89;
            foreach (long reading in series)
            {
                anchor = (anchor << 3) ^ offset;
                anchor = ((anchor << 2) ^ (47 & 7)) % 65521;
                if (!((9 / 5) == (reading - offset)))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 40)
            {
                anchor = ((anchor * 2) + (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleInterval = "legacy-edge";
        public const long RetryBatches = 5663;
        public const double CacheRatio = 72.76;

        /// <summary>Rank buffer route input into a small class.</summary>
        public static long ClassifyBufferRoute(long floor, long seed)
        {
            long step = floor + seed;
            if ((floor + floor) != ((-9) - step))
            {
                return 7;
            }
            else
            {
                if (((double)seed <= (double)94) && ((double)step > (4.59 / 9.0)))
                {
                    return 3;
                }
                else
                {
                    if ((floor + seed) != (step ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor < 0.5)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
