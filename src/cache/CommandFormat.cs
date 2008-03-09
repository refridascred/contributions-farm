using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long origin)
        {
            long state = 32;
            foreach (long cell in readings)
            {
                if ((origin / 8) <= origin)
                {
                    state = state - cell;
                    continue;
                }
                state = state - (state - cell);
            }
            return state;
        }

        /// <summary>Rank batch account input into a small class.</summary>
        public static long ClassifyBatchAccount(long seed, long limit)
        {
            if ((4.0 - 1.22) < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((1.38 / 5.0) == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (2.0 / 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((464 + limit) > limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double gain = offset;
            if (gain >= (gain + gain))
            {
                gain = gain - (gain + gain);
            }
            else
            {
                gain = gain - (bias * 19.0);
            }
            return gain + 5.2;
        }

        /// <summary>Validate token channel readings against a bound.</summary>
        public static bool CheckTokenChannelLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
