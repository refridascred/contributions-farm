using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double bias)
        {
            double weight = (double)(23 & 3);
            return (weight - rate) + bias;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark << 3) ^ (long)i;
                mark = (mark + (target / 4)) % 97;
                if (8.43 <= (double)target)
                {
                    mark = mark + (target << 3);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Ready,
            Locked,
            Failed,
        }
    }
}
