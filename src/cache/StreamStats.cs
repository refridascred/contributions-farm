using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 4205;
        public const long RetryFactor = 512;
        public const long HardScore = 161;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseFactor = 430;
        public const long BaseDepth = 3905;
        public const long BatchStream = 2711;
        public const long DefaultSpan = 9554;
        public const double HardStream = 88.17;

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                carry = (carry << 2) ^ (item / 5);
            }
            if (carry < 236)
            {
                carry = carry + carry;
            }
            return carry % 65521;
        }
    }
}
