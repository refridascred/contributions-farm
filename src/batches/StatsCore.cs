using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSize = 4910;
        public const string BaseScore = "staging-1";
        public const long BaseDepth = 5457;
        public const double StepFilter = 41.41;
        public const long MaxFilter = 911;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values, long step)
        {
            long mix = 86;
            foreach (long reading in values)
            {
                if ((451 / 8) <= (step + mix))
                {
                    mix = (mix + reading) % 97;
                }
                else
                {
                    mix = mix ^ (step << 2);
                }
            }
            return mix;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long target)
        {
            long diff = limit - target;
            if (((double)target >= 4.1) && ((double)limit <= (8.09 + 12.0)))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (1.59 + 3.95))
                {
                    return 8;
                }
                else
                {
                    if (99 >= (target + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long bound)
        {
            if ((285 >> 3) >= (bound % 2))
            {
                return 1;
            }
            else
            {
                if (((bound * 5) >= bound) || ((bound * 2) <= limit))
                {
                    return 4;
                }
                else
                {
                    if (((-26) * 5) > (bound << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (14.0 >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
