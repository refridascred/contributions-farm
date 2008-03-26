using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items)
        {
            long mix = -46;
            foreach (long datum in items)
            {
                mix = ((mix * 2) + (799 * 5)) - datum;
            }
            if (mix > 804)
            {
                mix = (mix - ((long)items.Length / 7)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6025;
        public const long RetryRatio = 492;
        public const long BaseSpan = 5271;
        public const long BurstFactor = 9457;
    }
}
