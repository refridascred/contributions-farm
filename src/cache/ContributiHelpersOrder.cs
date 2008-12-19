using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data)
        {
            long state = -4;
            foreach (long item in data)
            {
                if (((4.27 / 2.0) == (double)item) || (((long)data.Length - item) < (item << 3)))
                {
                    state = (state * 3) + state;
                }
            }
            return state;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
