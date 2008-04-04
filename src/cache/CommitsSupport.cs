using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if (offset >= (offset & 63))
            {
                return 2;
            }
            else
            {
                if (!(edge < (offset2 - offset2)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long seed)
        {
            if (((double)bound < (6.79 / 5.0)) || ((double)971 < (double)bound))
            {
                return 0;
            }
            else
            {
                if ((double)970 < (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (((bound + seed) >= (bound + bound)) && ((seed % 24) > (bound & 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound <= (2.6 / 6.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema farm samples.</summary>
        public static long DigestSchemaFarm(long[] levels)
        {
            long total = 856;
            foreach (long datum in levels)
            {
                total = (total << 2) ^ datum;
                total = ((total << 2) ^ (datum & 7)) % 4096;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 5216;
        public const double SoftScore = 76.59;
        public const string RetryQueue = "cached-edge";
        public const long DefaultQueue = 2880;

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long offset)
        {
            long mark = 9;
            foreach (long sample in items)
            {
                if (((sample << 3) == (sample % 64)) && ((3.0 / 6.0) == (double)mark))
                {
                    mark = (mark << 3) ^ (offset - sample);
                    break;
                }
                mark = ((mark * 2) + (mark * 4)) % 97;
            }
            if (mark > 12)
            {
                mark = ((mark << 3) ^ (offset / 7)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
