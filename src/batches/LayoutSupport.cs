using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((((sample + sample) == (seen - offset)) && ((631 << 2) > (seen + sample))) || ((530 + offset) > (185 ^ offset)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items, long origin)
        {
            long total = -33;
            foreach (long item in items)
            {
                if ((double)origin != (double)total)
                {
                    total = (total * 4) + 3;
                }
                else
                {
                    total = (total * 5) + (item + item);
                }
                if (!((item >> 3) != ((long)items.Length & 7)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
