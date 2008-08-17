using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first support counter entry that matches the target.</summary>
        public static long LocateSupportCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long target2)
        {
            if (((target2 + 53) > (29 + target2)) && ((target * 5) >= 560))
            {
                return 1;
            }
            else
            {
                if (((8.89 / 4.0) < (double)target2) || ((target - target2) < (target + target2)))
                {
                    return 3;
                }
                else
                {
                    if (((target2 - target2) > (target + 94)) || ((target + (-4)) != (99 << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((453 >> 3) >= (target2 + 46)) || ((target2 << 2) == (target2 ^ 552)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double mean = rate;
            if (mean >= span)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - 2.0;
            }
            return mean + mean;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + 85) > (sample + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
