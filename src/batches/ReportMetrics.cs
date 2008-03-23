using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long DeriveEntryAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ ((long)i / 7)) % 97;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long target)
        {
            long lane = seed + target;
            if ((double)lane < 3.0)
            {
                return 5;
            }
            else
            {
                if ((double)seed < 20.0)
                {
                    return 8;
                }
                else
                {
                    if (((double)378 <= (double)seed) || ((double)seed != (9.5 / 8.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((seed & 1) > (target >> 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
