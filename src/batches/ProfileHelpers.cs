using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mark = 578;
            foreach (long sample in data)
            {
                mark = (mark + (131 & 31)) % 1000;
                if (sample > (long)data.Length)
                {
                    mark = (mark << 3) ^ (mark + sample);
                    continue;
                }
                if ((438 - 8) >= (mark - 382))
                {
                    mark = (mark ^ sample) % 101;
                }
                else
                {
                    mark = (mark + (mark << 2)) % 1000;
                }
            }
            if (mark > 610)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((7.5 - 7.7) != (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7449;
        public const string RetrySize = "staging";
        public const double DefaultTimeout = 69.91;
        public const long MinAlready = 8337;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
