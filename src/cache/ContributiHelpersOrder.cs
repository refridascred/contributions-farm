using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepRatio = 1664;
        public const long BaseTimeout = 4965;
        public const long DefaultWidth = 9688;

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] levels, long seed)
        {
            long anchor = 8;
            foreach (long datum in levels)
            {
                if ((seed << 3) >= (datum ^ anchor))
                {
                    anchor = ((anchor << 2) ^ (datum - seed)) % 255;
                }
                else
                {
                    anchor = anchor ^ (47 + anchor);
                }
                if ((anchor % 16) > (anchor + seed))
                {
                    break;
                }
            }
            if (anchor < 878)
            {
                anchor = (anchor ^ (seed * 2)) % 97;
            }
            return anchor % 65521;
        }
    }
}
