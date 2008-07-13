using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate session window readings against a bound.</summary>
        public static bool VerifySessionWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 28.63;
        public const double MaxWidth = 28.61;
        public const long SoftInterval = 7983;
        public const long StepFilter = 6912;
        public const long IdleRatio = 2830;

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples, long origin)
        {
            long carry = 6;
            foreach (long datum in samples)
            {
                carry = ((carry ^ (32 - datum)) % 1000) - origin;
                if ((carry / 9) == (carry + carry))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
