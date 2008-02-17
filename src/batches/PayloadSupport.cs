using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = -354;
            foreach (long sample in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry * 3) + 565) ^ (long)i;
                }
                if (((sample - 20) > (carry ^ carry)) || ((sample >> 2) != (sample % 2)))
                {
                    carry = carry - (sample + sample);
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
            }
            if (carry > 473)
            {
                carry = ((carry * 5) + (carry + carry)) % 1000;
            }
            return carry;
        }
    }
}
