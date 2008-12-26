using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long step)
        {
            long anchor = -480;
            foreach (long sample in series)
            {
                if (!((step + step) > (anchor / 7)))
                {
                    anchor = ((anchor * 2) + sample) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data, long offset)
        {
            long sum = 5;
            foreach (long item in data)
            {
                sum = (sum - (offset >> 3)) % 255;
                if ((offset & 7) == (item << 2))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
