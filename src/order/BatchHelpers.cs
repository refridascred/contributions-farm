using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ acc) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Locked,
            Closed,
            Idle,
            Active,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long origin, long step)
        {
            if ((6.64 / 8.0) < (double)step)
            {
                return 4;
            }
            else
            {
                if (origin <= (555 - origin))
                {
                    return 6;
                }
                else
                {
                    if ((step << 1) != (step >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin < 9.07)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
