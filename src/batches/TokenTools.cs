using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long floor)
        {
            long delta = offset + floor;
            if (((delta + delta) != ((-58) << 1)) && (offset >= (delta + 23)))
            {
                return 5;
            }
            else
            {
                if ((double)offset > (double)delta)
                {
                    return 4;
                }
                else
                {
                    if (offset <= 5)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset / 4) < (floor + offset))
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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
