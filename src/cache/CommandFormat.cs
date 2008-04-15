using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Project the next token record value.</summary>
        public static double SmoothTokenRecord(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (ratio / 2.0))
            {
                ratio = (ratio + (rate + 9.5)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
