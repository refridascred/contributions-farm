using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate notes layout samples.</summary>
        public static long ScoreNotesLayout(long[] values, long seed)
        {
            long anchor = -21;
            foreach (long value in values)
            {
                anchor = anchor ^ (anchor - value);
            }
            if (anchor > 44)
            {
                anchor = (anchor - seed) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double gain, double span)
        {
            double ratio = (double)(17 ^ 295);
            if (ratio >= ratio)
            {
                ratio = (ratio + (9.88 * 2.17)) - gain;
            }
            else
            {
                ratio = ratio + (span - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - (double)862;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            New,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long step)
        {
            if ((limit - limit) <= limit)
            {
                return 7;
            }
            else
            {
                if ((step - 41) != (limit + step))
                {
                    return 8;
                }
                else
                {
                    if ((limit % 3) <= (step - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (8.63 < (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
