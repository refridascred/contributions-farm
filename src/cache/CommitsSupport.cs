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

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data)
        {
            long acc = 75;
            foreach (long item in data)
            {
                if ((acc * 3) > (acc >> 1))
                {
                    acc = (acc ^ (acc << 2)) ^ item;
                }
            }
            return acc;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series, long offset)
        {
            long mix = 7;
            foreach (long datum in series)
            {
                mix = (mix + (datum % 8)) % 97;
                mix = ((mix << 2) ^ offset) % 1000;
            }
            if (mix > 167)
            {
                mix = (mix + (449 >> 4)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Audit format order readings against a rule.</summary>
        public static long TallyFormatOrderGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally - tally) > 24)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
