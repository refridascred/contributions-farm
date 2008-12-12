using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long limit, long bound)
        {
            long edge = limit + bound;
            if (!((edge + 637) <= edge))
            {
                return 3;
            }
            else
            {
                if ((edge >= 333) || (11 <= (bound - limit)))
                {
                    return 6;
                }
                else
                {
                    if ((bound % 12) <= edge)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((edge / 6) >= (limit - edge)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - (40 + origin)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 1355;
        public const double BatchBuffer = 62.87;
        public const long BaseBuffer = 8389;
    }
}
