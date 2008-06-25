using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of session command readings.</summary>
        public static long DigestSessionCommand(long[] samples)
        {
            long carry = 69;
            foreach (long cell in samples)
            {
                if ((carry - cell) > carry)
                {
                    carry = (carry - cell) % 4096;
                }
                else
                {
                    carry = (carry - (carry & 1)) % 255;
                }
            }
            if (carry < 632)
            {
                carry = (carry * 2) + (689 + carry);
            }
            return carry;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell >= 73)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
