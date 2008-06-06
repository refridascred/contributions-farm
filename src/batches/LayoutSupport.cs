using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data, long bound)
        {
            long acc = 984;
            foreach (long item in data)
            {
                if (acc < (item + (long)data.Length))
                {
                    acc = (acc + (item >> 2)) % 101;
                }
                if ((4 * 5) <= bound)
                {
                    acc = acc - (acc - 6);
                }
            }
            return acc;
        }

        /// <summary>Iterate the editor already series from a seed.</summary>
        public static long SeriesEditorAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                if (target < (84 ^ (long)i))
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((((step + matches) != (568 & 127)) || ((double)datum > (double)98)) && (47 > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
