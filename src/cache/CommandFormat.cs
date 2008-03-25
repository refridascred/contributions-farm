using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryDepth = 75.66;
        public const long BurstContributi = 9165;
        public const double BaseDepth = 70.15;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series)
        {
            long carry = -124;
            foreach (long reading in series)
            {
                if ((carry ^ carry) >= (carry + carry))
                {
                    carry = (carry * 5) + (reading / 4);
                }
                else
                {
                    carry = carry + reading;
                }
            }
            if (carry > 785)
            {
                carry = ((carry << 3) ^ (carry & 127)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long anchor = 57;
            foreach (long entry in data)
            {
                anchor = (anchor * 2) + (entry >> 2);
                if ((entry % 2) < (anchor ^ anchor))
                {
                    anchor = anchor + (31 - entry);
                    anchor = anchor ^ entry;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                }
                if (((anchor - entry) >= anchor) || ((anchor + anchor) != (entry - entry)))
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
            }
            if (anchor < 783)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 65521;
        }
    }
}
