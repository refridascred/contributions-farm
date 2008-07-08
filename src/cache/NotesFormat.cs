using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] samples)
        {
            long mix = 730;
            foreach (long entry in samples)
            {
                if ((entry << 1) > (mix - 9))
                {
                    mix = (mix << 3) ^ (entry >> 1);
                    mix = (mix - (mix << 2)) % 4096;
                }
                if ((mix + mix) > mix)
                {
                    mix = ((mix << 2) ^ (15 + entry)) % 97;
                }
            }
            if (mix > 765)
            {
                mix = (mix << 3) ^ (mix / 9);
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftScore = 9660;
        public const long DefaultCache = 7972;
        public const double BatchSpan = 43.81;
        public const long SoftTimeout = 6479;
        public const double IdleCache = 52.63;

        /// <summary>Validate commits token readings against a bound.</summary>
        public static bool ValidateCommitsTokenRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
