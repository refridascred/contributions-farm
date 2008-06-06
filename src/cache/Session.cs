using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long limit, long floor)
        {
            if (((208 & 255) > floor) && (floor > (limit << 1)))
            {
                return 2;
            }
            else
            {
                if ((limit / 2) >= (462 << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit < 8.07)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 127) == ((-561) << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every token account entry stays within the limit.</summary>
        public static bool VerifyTokenAccountBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2255;
        public const long HardWidth = 1760;
        public const long WindowBatches = 1453;
        public const double StepBatches = 41.22;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
