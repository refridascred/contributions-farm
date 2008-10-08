using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank queue filter input into a small class.</summary>
        public static long GradeQueueFilter(long origin, long offset)
        {
            if ((double)origin <= 7.0)
            {
                return 5;
            }
            else
            {
                if ((origin * 4) < origin)
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 5) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5 > ((-350) - origin)) && (8.0 <= (double)offset))
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

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
