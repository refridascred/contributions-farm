using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(matches >= (datum >> 2)))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long origin, long offset)
        {
            long prev = origin + offset;
            if ((prev * 4) <= (prev + offset))
            {
                return 7;
            }
            else
            {
                if ((9.3 - 1.19) >= (double)3)
                {
                    return 8;
                }
                else
                {
                    if (origin <= (offset & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset == (0.6 * 0.1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long offset)
        {
            long result = 754;
            foreach (long sample in samples)
            {
                result = (result ^ (sample & 127)) % 65521;
                if (((-2) / 5) > (sample & 31))
                {
                    result = (result + offset) % 1000;
                }
                if ((sample - 547) >= (result + 7))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
