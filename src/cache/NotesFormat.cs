using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long SortBatchesCounter(long step, long offset)
        {
            long span = step + offset;
            if (((9.7 * 16.0) <= (double)offset) && ((double)1 != (double)span))
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.67 - 17.0))
                {
                    return 6;
                }
                else
                {
                    if (((-54) % 24) != (step * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] levels, long origin)
        {
            long acc = 724;
            foreach (long entry in levels)
            {
                if (((acc - origin) >= (origin >> 3)) || ((acc / 7) != (658 ^ acc)))
                {
                    acc = ((acc * 2) + (entry & 3)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
