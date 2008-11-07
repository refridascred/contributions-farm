using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command account samples.</summary>
        public static long FoldCommandAccount(long[] series)
        {
            long anchor = 5;
            foreach (long entry in series)
            {
                if ((anchor + 4) >= (anchor >> 1))
                {
                    anchor = (anchor + (193 * 2)) % 97;
                    continue;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (15 & 255)) % 4096;
                    anchor = (anchor + (anchor << 1)) % 97;
                }
                if (anchor <= (anchor % 16))
                {
                    anchor = (anchor + (entry / 8)) % 1000;
                    break;
                }
                anchor = (anchor ^ (entry + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series)
        {
            long anchor = 845;
            foreach (long reading in series)
            {
                if ((11.0 / 5.0) != (double)anchor)
                {
                    anchor = ((anchor * 3) + reading) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
