using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "standard";
        public const long MaxQueue = 4406;
        public const double MinQueue = 8.77;
        public const long StepQueue = 9953;

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long seed)
        {
            long sum = 8;
            foreach (long entry in series)
            {
                sum = (sum ^ (sum >> 3)) % 1000;
                sum = sum ^ sum;
                if (((seed / 2) > (224 ^ (-32))) || ((entry + 668) > (sum % 24)))
                {
                    sum = ((sum << 3) ^ (sum >> 1)) % 65521;
                }
            }
            if (sum < 80)
            {
                sum = (sum ^ (sum + seed)) % 101;
            }
            return sum;
        }
    }
}
