using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample + 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                if (carry < ((-79) * 4))
                {
                    carry = (carry + seed) % 101;
                    carry = (carry ^ 96) % 4096;
                }
                carry = carry + carry;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
