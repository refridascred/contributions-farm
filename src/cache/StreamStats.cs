using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine commits layout values into a single score.</summary>
        public static long DigestCommitsLayout(long[] values)
        {
            long result = 34;
            foreach (long cell in values)
            {
                if ((result & 255) > (result & 7))
                {
                    result = (result * 2) + (cell & 7);
                }
            }
            return result;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 4) + (total / 3)) % 101) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
