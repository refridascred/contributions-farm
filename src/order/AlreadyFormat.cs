using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool ValidateProfileFormatBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long step)
        {
            long total = 710;
            foreach (long reading in values)
            {
                total = ((total + (total - step)) % 1000) + reading;
            }
            return total % 65521;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
