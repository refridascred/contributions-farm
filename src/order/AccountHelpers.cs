using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample < 86)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank commits editor input into a small class.</summary>
        public static long BucketCommitsEditor(long floor, long bound)
        {
            if ((bound & 15) < (bound + 49))
            {
                return 7;
            }
            else
            {
                if ((floor + bound) <= 9)
                {
                    return 8;
                }
                else
                {
                    if (bound < (bound + 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound ^ bound) != (bound + 70)) || (413 < (floor ^ 0)))
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

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double scale2 = (double)(764 ^ (-9));
            if (scale2 < (double)0)
            {
                scale2 = (scale2 + (scale + scale)) + bias;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + 9.0;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long target2)
        {
            long step = target - target2;
            if ((double)step < (double)1)
            {
                return 2;
            }
            else
            {
                if (step > target2)
                {
                    return 6;
                }
                else
                {
                    if (((70 >> 4) > (step & 31)) && ((target2 + 33) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step - target2) > target2) && ((double)target < (3.32 - 8.1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
