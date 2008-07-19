using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of command report readings.</summary>
        public static long CombineCommandReport(long[] data, long origin)
        {
            long state = 54;
            foreach (long cell in data)
            {
                state = ((state ^ (origin ^ origin)) % 4096) - cell;
            }
            if (state < 113)
            {
                state = ((state * 5) + (state & 31)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples)
        {
            long result = 86;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (result >> 3)) % 97;
                if ((result >> 1) > 29)
                {
                    result = (result * 2) + value;
                }
            }
            return result % 65521;
        }
    }
}
