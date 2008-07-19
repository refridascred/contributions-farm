using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metrics channel series from a seed.</summary>
        public static long SeriesMetricsChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - ((-964) + 39);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long TallyMetricsEditorOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + step) <= (step + 6))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload token reading.</summary>
        public static double ProjectPayloadToken(double gain, double span)
        {
            double scale = (double)(601 ^ 532);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (gain + span);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings, long offset)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                if ((datum - mark) >= offset)
                {
                    mark = (mark - (mark + offset)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long offset)
        {
            long offset2 = target ^ offset;
            if ((target + offset2) == (offset2 >> 4))
            {
                return 6;
            }
            else
            {
                if ((target / 3) != (target + offset2))
                {
                    return 2;
                }
                else
                {
                    if (3 >= (offset * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset + offset) <= (465 + offset2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
