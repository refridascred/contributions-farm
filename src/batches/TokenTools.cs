using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of record window entries.</summary>
        public static long DigestRecordWindow(long[] series)
        {
            long anchor = 1;
            foreach (long datum in series)
            {
                if (((1.7 * 4.5) != (double)anchor) && ((anchor << 1) == (anchor / 7)))
                {
                    anchor = (anchor - (98 ^ datum)) % 97;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor << 3) ^ (anchor & 7)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
