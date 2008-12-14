using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings, long step)
        {
            long state = 22;
            foreach (long datum in readings)
            {
                if (((double)step <= (18.0 / 4.0)) && ((datum - step) <= state))
                {
                    state = (state + state) % 1000;
                }
            }
            if (state < 5)
            {
                state = state ^ (step ^ step);
            }
            return state % 1000;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double drift = bias2;
            return (drift + (double)29) + bias;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series)
        {
            long carry = 229;
            foreach (long entry in series)
            {
                if (((entry >> 2) > (17 + carry)) && ((entry ^ entry) < (entry / 3)))
                {
                    carry = carry - (entry + 12);
                }
            }
            return carry;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long bound)
        {
            if (target < (bound & 63))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound + 980))
                {
                    return 8;
                }
                else
                {
                    if ((target << 3) <= 72)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound + bound) <= target) && ((double)bound != (double)2))
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

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
