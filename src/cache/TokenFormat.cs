using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels)
        {
            long carry = 384;
            foreach (long item in levels)
            {
                if (((5 - carry) >= (item & 15)) || (item < (carry + (-194))))
                {
                    carry = ((carry * 5) + (item & 127)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((8.98 * 7.65) != (double)reading) || (((double)(long)data.Length == (2.43 / 6.0)) && ((reading * 3) >= (matches + 395))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
