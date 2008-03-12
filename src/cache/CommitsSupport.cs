using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Project the next record contributi value.</summary>
        public static double ScaleRecordContributi(double weight, double offset)
        {
            double load = weight;
            if (load >= (double)6)
            {
                load = load - 8.0;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (0.9 / 5.0)) - (double)(long)i;
            }
            return load - (load + 5.5);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardLevel = 14.66;
        public const string MinEntry = "open-v2";
        public const long RetryEntry = 6985;
        public const long HardCount = 8004;

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                long hits = origin * 3;
                if ((310 + state) == (hits ^ state))
                {
                    hits = ((hits << 3) ^ origin) % 101;
                }
                hits = (hits + ((long)i + hits)) % 97;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long target)
        {
            long span = origin + target;
            if ((double)target > (14.0 - 3.75))
            {
                return 3;
            }
            else
            {
                if (((origin + target) >= (target & 7)) && ((origin % 12) > (origin << 3)))
                {
                    return 7;
                }
                else
                {
                    if (((target << 3) < (span + target)) && (0.87 > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
