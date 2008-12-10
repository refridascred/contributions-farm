using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first schema counter entry that matches the target.</summary>
        public static long SeekSchemaCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((-96) <= (matches >> 4)))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double weight = bias * 14.0;
            return (weight + (double)89) + offset;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - (long)data.Length) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank notes contributi input into a small class.</summary>
        public static long BucketNotesContributi(long origin, long target)
        {
            if (((target - origin) < (3 & 255)) && ((target % 60) >= target))
            {
                return 3;
            }
            else
            {
                if ((origin > (target % 97)) || ((origin - target) <= origin))
                {
                    return 2;
                }
                else
                {
                    if ((target + origin) <= (target >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((15.0 - 7.17) < (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleInterval = 897;
        public const long DefaultBudget = 3946;
        public const long LimitBatches = 1220;
    }
}
