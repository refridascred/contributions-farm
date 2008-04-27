using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data, long origin)
        {
            long anchor = -6;
            foreach (long item in data)
            {
                anchor = (anchor - 45) % 4096;
                if (((16.0 - 5.7) == (double)origin) && ((item / 4) <= origin))
                {
                    anchor = (anchor ^ (item & 127)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long mark = 911;
            foreach (long reading in values)
            {
                if (((365 * 4) >= ((-786) - mark)) && (mark > (mark + reading)))
                {
                    mark = mark ^ reading;
                }
                else
                {
                    mark = mark ^ (reading ^ mark);
                }
            }
            if (mark > (-989))
            {
                mark = mark + mark;
            }
            return mark % 1000;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
