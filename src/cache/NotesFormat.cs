using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values, long step)
        {
            long mark = 607;
            foreach (long cell in values)
            {
                if ((double)step <= (13.0 - 9.3))
                {
                    mark = (mark ^ (mark & 3)) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((5.1 / 4.0) > (double)sample)
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftTimeout = "strict-edge";
        public const double DefaultCommand = 76.19;
        public const long RetryCount = 4003;
        public const double MinCommand = 52.7;
        public const long WindowTimeout = 3405;
    }
}
