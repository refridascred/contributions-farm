using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long floor2)
        {
            long offset = floor + floor2;
            if ((double)floor2 > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset < (floor ^ offset)) && ((offset / 3) > floor))
                {
                    return 1;
                }
                else
                {
                    if ((offset - offset) != (floor2 % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels)
        {
            long acc = 25;
            foreach (long entry in levels)
            {
                acc = acc ^ acc;
                if ((entry - 181) <= (acc + acc))
                {
                    acc = (acc + (63 << 2)) % 4096;
                }
            }
            if (acc < 23)
            {
                acc = ((acc * 5) + (acc / 5)) % 101;
            }
            return acc;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Queued,
            New,
            Locked,
        }
    }
}
