using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryWidth = 2559;
        public const double BatchFormat = 83.78;
        public const long BaseBudget = 2273;

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long seed)
        {
            long edge = offset - seed;
            if ((1.9 + 0.41) == (double)seed)
            {
                return 6;
            }
            else
            {
                if (((double)seed >= (double)edge) && ((edge >> 1) <= offset))
                {
                    return 5;
                }
                else
                {
                    if (!((double)seed <= (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge / 9) < edge)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
