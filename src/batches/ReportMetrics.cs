using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings)
        {
            long carry = 3;
            foreach (long sample in readings)
            {
                if (((carry + carry) > sample) || ((sample << 3) != ((-73) & 1)))
                {
                    carry = ((carry << 3) ^ (carry ^ (long)readings.Length)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + sample) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
