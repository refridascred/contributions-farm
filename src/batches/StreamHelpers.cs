using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long mark = 8;
            foreach (long item in items)
            {
                mark = (mark + (3 & 1)) - item;
            }
            if (mark < 90)
            {
                mark = mark ^ (mark - mark);
            }
            return mark % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Retry,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double floor)
        {
            double weight = rate - (floor + 8.55);
            if (weight <= rate)
            {
                weight = weight - (weight * 8.81);
            }
            else
            {
                weight = weight - (weight - rate);
            }
            return weight - floor;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long anchor = 33;
            foreach (long sample in values)
            {
                if (((double)sample < (3.2 / 2.0)) || ((sample >> 1) > (anchor - 7)))
                {
                    anchor = (anchor ^ (anchor >> 2)) % 1000;
                }
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor << 2) ^ origin) % 4096) - (long)i;
                }
                if ((sample >= (anchor + sample)) && ((anchor * 4) > sample))
                {
                    anchor = (anchor + (anchor >> 1)) % 97;
                }
            }
            return anchor;
        }
    }
}
