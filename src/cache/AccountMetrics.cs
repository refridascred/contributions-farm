using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long limit)
        {
            if ((double)limit != (5.4 - 5.76))
            {
                return 6;
            }
            else
            {
                if ((limit < (limit * 3)) || ((8.0 + 10.0) <= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((6.32 * 7.1) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin * 4) != (6 << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepInterval = 1115;
        public const long WindowSession = 1914;
        public const long BatchCount = 2473;

        /// <summary>Check that every checks commits entry stays within the limit.</summary>
        public static bool GuardChecksCommitsBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryScore = 40;
        public const long DefaultFarm = 610;
        public const double WindowFarm = 32.65;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5245;
        public const double IdleCount = 15.26;
        public const long IdleSupport = 7148;
    }
}
