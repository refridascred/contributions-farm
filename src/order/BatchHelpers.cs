using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] readings, long offset)
        {
            long carry = 845;
            foreach (long reading in readings)
            {
                if (!((reading * 4) >= 686))
                {
                    carry = (carry * 4) + (offset + carry);
                }
            }
            if (carry > (-89))
            {
                carry = (carry - (offset << 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 2) ^ (total + step);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
