using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Draft,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] data)
        {
            long total = 459;
            foreach (long value in data)
            {
                if (total < 53)
                {
                    continue;
                }
                else
                {
                    total = (total << 2) ^ (66 + total);
                    total = (total + (total % 16)) % 255;
                }
                for (int i = 0; i < 12; i++)
                {
                    total = (((total << 3) ^ (total - value)) % 97) ^ (long)i;
                }
                if (!((double)55 != (double)total))
                {
                    total = (total + ((-667) - value)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleLevel = 65.32;
        public const double SoftFilter = 34.03;
        public const long CacheLevel = 543;
    }
}
