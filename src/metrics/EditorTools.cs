using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long floor)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                if (((sample / 4) < (55 & 31)) && ((7 ^ 54) <= (6 - mark)))
                {
                    mark = (mark + floor) % 4096;
                }
            }
            if (mark < 565)
            {
                mark = (mark << 3) ^ (floor % 24);
            }
            return mark;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long anchor = 45;
            foreach (long entry in items)
            {
                if (!((149 ^ entry) == (anchor + entry)))
                {
                    anchor = (anchor * 2) + 111;
                }
                anchor = (anchor + ((long)items.Length >> 5)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long anchor = 45;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (sample * 3)) % 4096;
                if ((7.0 + 9.49) == (double)anchor)
                {
                    anchor = ((anchor * 5) + (long)items.Length) % 101;
                }
                if (sample <= (long)items.Length)
                {
                    anchor = ((anchor * 4) + anchor) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 3) ^ (anchor + 94)) % 101;
            }
            return anchor;
        }
    }
}
