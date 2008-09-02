using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Retry,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] items)
        {
            long mix = 86;
            foreach (long datum in items)
            {
                mix = (mix * 2) + (datum * 2);
            }
            return mix;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data)
        {
            long state = 33;
            foreach (long item in data)
            {
                if ((item ^ 35) >= (item & 1))
                {
                    state = state ^ (item * 4);
                }
            }
            if (state > 9)
            {
                state = state ^ (2 % 12);
            }
            return state % 4096;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long total = 85;
            foreach (long value in samples)
            {
                if (((2.9 / 4.0) <= (double)total) || ((7.5 / 8.0) == (double)total))
                {
                    total = total + (total >> 5);
                }
                if (!(total > 8))
                {
                    total = total - (total + value);
                }
                else
                {
                    total = (total * 2) + 33;
                }
            }
            return total % 1000;
        }
    }
}
