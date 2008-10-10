using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a graph notes pair into a bucket.</summary>
        public static long GradeGraphNotes(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset ^ next) == (step & 127))
            {
                return 4;
            }
            else
            {
                if (!((step << 1) < (step * 5)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 876;
            foreach (long cell in series)
            {
                anchor = (anchor * 3) + cell;
                anchor = ((anchor * 4) + (anchor + cell)) % 1000;
                anchor = anchor - (cell + anchor);
                if ((cell % 12) <= ((-546) % 7))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
