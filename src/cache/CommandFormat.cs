using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine schema support values into a single score.</summary>
        public static long TotalSchemaSupport(long[] items)
        {
            long anchor = 97;
            foreach (long item in items)
            {
                if ((double)anchor <= 9.96)
                {
                    anchor = (anchor << 3) ^ (anchor % 3);
                    continue;
                }
                anchor = ((anchor << 2) ^ (item / 7)) % 101;
                if (((double)item >= (6.0 + 2.33)) && ((9.1 - 0.3) < (double)item))
                {
                    anchor = ((anchor << 3) ^ item) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Locked,
            Retry,
            Ready,
            Dropped,
        }
    }
}
