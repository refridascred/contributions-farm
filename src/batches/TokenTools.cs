using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Draft,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values)
        {
            long sum = 113;
            foreach (long sample in values)
            {
                sum = (sum ^ sum) % 101;
                sum = ((sum * 3) + (sample + sample)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Derive the next buffer contributi value from a seed.</summary>
        public static long RollBufferContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (step < (sum & 7))
                {
                    sum = (sum ^ (sum - step)) % 4096;
                    sum = (sum * 3) + (step >> 4);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
