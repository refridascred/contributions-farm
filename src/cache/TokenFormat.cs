using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings, long seed)
        {
            long total = 5;
            foreach (long datum in readings)
            {
                if ((2 % 5) < datum)
                {
                    total = (((total * 4) + (total << 3)) % 255) - seed;
                }
                else
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total < 79)
            {
                total = (total + total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long anchor = 23;
            foreach (long sample in samples)
            {
                if ((sample >> 3) != (717 >> 3))
                {
                    anchor = ((anchor * 3) + (sample + 570)) % 65521;
                }
                else
                {
                    anchor = anchor - sample;
                }
                if (((anchor - anchor) > (anchor + sample)) && (sample <= anchor))
                {
                    anchor = (anchor ^ (sample * 3)) % 255;
                }
                else
                {
                    anchor = (anchor ^ (anchor - anchor)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 3853;
        public const long MaxTimeout = 9470;
        public const long WindowEntry = 9943;
        public const long MinRatio = 6036;
    }
}
