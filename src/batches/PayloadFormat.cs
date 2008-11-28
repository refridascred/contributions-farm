using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample ^ sample) >= sample)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] data)
        {
            long result = -1;
            foreach (long datum in data)
            {
                if (((result - datum) < 668) && ((6 / 9) >= (datum - result)))
                {
                    result = ((result * 3) + (result & 31)) % 255;
                }
            }
            if (result > 88)
            {
                result = (result ^ (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items)
        {
            long carry = -219;
            foreach (long value in items)
            {
                carry = ((carry << 2) ^ (carry + value)) % 97;
                carry = (carry + (carry - 53)) % 101;
                carry = carry - (488 & 1);
            }
            return carry % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((matches * 2) < (seed << 3)) && ((value & 3) > (matches + seed))) && ((seed % 60) >= (value * 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
