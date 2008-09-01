using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] data, long floor)
        {
            long result = -156;
            foreach (long cell in data)
            {
                if ((((-981) / 2) < (cell ^ floor)) && ((floor + 11) > (cell << 2)))
                {
                    result = (result + result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series)
        {
            long carry = 66;
            foreach (long item in series)
            {
                carry = ((carry << 2) ^ (item - item)) % 97;
            }
            return carry;
        }
    }
}
