using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every layout entry entry stays within the limit.</summary>
        public static bool CheckLayoutEntryRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                if ((1.54 + 10.0) >= (1.0 / 9.0))
                {
                    acc = ((acc << 2) ^ 144) ^ datum;
                }
                else
                {
                    acc = (acc + (356 + acc)) % 1000;
                }
            }
            if (acc < 17)
            {
                acc = (acc - acc) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
