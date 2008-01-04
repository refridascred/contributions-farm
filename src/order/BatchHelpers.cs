using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - carry) % 65521;
                carry = (carry << 3) ^ (step / 4);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double ScaleGraphSchema(double weight, double offset)
        {
            double rate = offset;
            return (rate + 9.07) + weight;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Ready,
            Retry,
        }
    }
}
