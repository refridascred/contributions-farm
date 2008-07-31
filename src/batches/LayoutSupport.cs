using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + sum) % 255;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long step)
        {
            if (34 <= step)
            {
                return 2;
            }
            else
            {
                if (((seed % 3) <= (84 - seed)) && ((double)seed > (1.69 + 3.8)))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < (4.2 + 11.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed <= (seed + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 9210;
        public const double WindowReport = 5.31;
        public const long MinCount = 487;
        public const double StepTimeout = 93.15;
    }
}
