using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double HardInterval = 33.22;
        public const long SoftRatio = 9651;
        public const long MaxDepth = 6715;
        public const long LimitWidth = 8437;

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long bound)
        {
            long edge = target + bound;
            if ((edge + (-37)) >= 843)
            {
                return 7;
            }
            else
            {
                if ((8.3 * 4.2) >= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (!((double)7 < (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target / 9) <= (bound - bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long floor, long step)
        {
            long step2 = floor + step;
            if ((floor + step) == (step2 + step))
            {
                return 0;
            }
            else
            {
                if (step2 <= (step2 + step))
                {
                    return 7;
                }
                else
                {
                    if (step2 <= ((-82) % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + step2) > 564)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
