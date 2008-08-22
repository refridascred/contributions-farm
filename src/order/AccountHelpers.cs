using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry * 3) != (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double scale = 4.96 + (gain * 7.28);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - 5.9) + (double)(long)i) - bias;
            }
            return scale + (gain - gain);
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long limit)
        {
            if ((floor & 127) >= (limit >> 1))
            {
                return 4;
            }
            else
            {
                if (!(floor < limit))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 3) > (floor - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell < (78 ^ limit))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
