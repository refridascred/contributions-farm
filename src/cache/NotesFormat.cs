using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings)
        {
            long mix = 58;
            foreach (long entry in readings)
            {
                if ((6.3 / 6.0) == (double)mix)
                {
                    mix = mix - 1;
                }
                mix = (mix - mix) % 97;
                mix = ((mix * 5) + entry) % 101;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultLevel = "cached-edge";
        public const long BatchStats = 6863;
        public const string HardLevel = "open-v2";
        public const long RetryStats = 7362;
        public const long CacheCount = 8611;

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] values)
        {
            long sum = 2;
            foreach (long value in values)
            {
                if ((4.48 + 7.3) > (double)sum)
                {
                    sum = ((sum ^ (sum - 7)) % 101) + value;
                }
            }
            if (sum > 62)
            {
                sum = (sum ^ (sum + sum)) % 1000;
            }
            return sum % 4096;
        }
    }
}
