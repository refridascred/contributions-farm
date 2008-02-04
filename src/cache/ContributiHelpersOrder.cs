using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long step, long limit)
        {
            long prev = step ^ limit;
            if ((6.58 + 5.84) > (double)prev)
            {
                return 1;
            }
            else
            {
                if (prev > (prev << 3))
                {
                    return 7;
                }
                else
                {
                    if (8 < (limit + prev))
                    {
                        return 2;
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
