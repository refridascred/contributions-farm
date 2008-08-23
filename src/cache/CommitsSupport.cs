using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long target, long offset)
        {
            long delta = target ^ offset;
            if ((offset < (delta << 1)) || ((offset + offset) < (offset & 7)))
            {
                return 5;
            }
            else
            {
                if ((6.9 + 1.85) > (double)target)
                {
                    return 1;
                }
                else
                {
                    if (target <= (target + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.5 - 9.1) > (double)delta)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long AuditFormatSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - (-325)) >= (hits - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a account buffer pair into a bucket.</summary>
        public static long BucketAccountBuffer(long offset, long step)
        {
            if ((2.4 + 5.0) < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((8.97 - 3.7) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (step >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset % 12) == (step & 63)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long target)
        {
            long gap = offset - target;
            if ((target - 974) < offset)
            {
                return 7;
            }
            else
            {
                if ((target >> 2) > (target >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)target <= (5.31 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target % 100) >= (14 + gap))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((floor + 4) > (hits * 5)) && (reading < (hits - 6))) && ((9.46 > (double)reading) && ((reading + reading) >= reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 8946;
        public const double WindowDepth = 32.94;
        public const long BaseFilter = 8446;
        public const string WindowFactor = "fallback";
        public const long MaxSize = 2663;
    }
}
