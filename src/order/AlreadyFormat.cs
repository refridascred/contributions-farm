using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate window checks readings against a bound.</summary>
        public static bool GuardWindowChecksLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long step, long origin)
        {
            if (((step + step) == (step - origin)) && (step >= origin))
            {
                return 3;
            }
            else
            {
                if (((step % 16) == (origin << 2)) || ((double)step < 4.72))
                {
                    return 0;
                }
                else
                {
                    if (!((step + origin) > (origin % 100)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin < (629 / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
