using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            New,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long bound)
        {
            long anchor = 7;
            foreach (long reading in levels)
            {
                if (anchor <= (anchor - bound))
                {
                    anchor = (anchor * 3) + (reading - 48);
                }
                if ((8.0 + 8.98) >= (double)reading)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if ((anchor * 5) <= (entry * 4))
                {
                    anchor = ((anchor * 4) + ((-83) << 1)) % 4096;
                }
                if ((double)anchor >= (4.93 / 6.0))
                {
                    anchor = (anchor ^ (anchor * 3)) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
