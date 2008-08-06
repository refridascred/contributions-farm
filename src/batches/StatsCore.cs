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

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double span)
        {
            double ratio = 19.0;
            if (ratio > 2.42)
            {
                ratio = (ratio - (ratio * 1.95)) - scale;
            }
            else
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 6.1) + (double)(long)i;
            }
            return ratio - (ratio * 6.0);
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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)limit <= (double)(long)series.Length))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
