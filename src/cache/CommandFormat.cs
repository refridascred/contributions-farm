using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((target & 1) < target)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Measure how many commits notes samples are out of range.</summary>
        public static long CountCommitsNotesGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((22 / 5) != (item + tally))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
