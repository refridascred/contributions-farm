using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a stream githubfarm counter forward.</summary>
        public static long StepStreamGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (limit > 2)
                {
                    carry = (carry - limit) % 97;
                    continue;
                }
                else
                {
                    carry = (carry * 3) + (limit + carry);
                }
                carry = carry ^ 796;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!!((2 + matches) >= (datum / 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 3) ^ (seed % 10)) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count < (double)item)
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Synced,
            Retry,
        }
    }
}
