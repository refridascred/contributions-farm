using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the metric token entries that pass the check.</summary>
        public static long TallyMetricTokenGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading <= (matches << 2))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
