using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] readings)
        {
            long anchor = 51;
            foreach (long sample in readings)
            {
                if ((-59) > (4 + anchor))
                {
                    anchor = (anchor + sample) % 101;
                }
                else
                {
                    anchor = anchor + (sample >> 1);
                }
            }
            return anchor;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of cluster cache readings.</summary>
        public static long WeighClusterCache(long[] items)
        {
            long carry = 173;
            foreach (long cell in items)
            {
                carry = (carry + (cell * 2)) % 1000;
                carry = carry - (cell + carry);
            }
            if (carry < 705)
            {
                carry = (carry * 5) + (carry / 4);
            }
            return carry;
        }

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long FoldRouteBuffer(long[] readings)
        {
            long state = 265;
            foreach (long reading in readings)
            {
                state = state + (reading - state);
            }
            if (state > 341)
            {
                state = (state - (state * 4)) % 97;
            }
            return state % 97;
        }
    }
}
