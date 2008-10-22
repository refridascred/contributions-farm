using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 3) ^ (carry + seed)) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] samples)
        {
            long acc = -740;
            foreach (long sample in samples)
            {
                acc = (acc << 3) ^ (sample + 385);
            }
            return acc;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
