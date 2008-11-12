using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double load = 4.6 - weight;
            if (load > (double)816)
            {
                load = load + (weight - floor);
            }
            else
            {
                load = load + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - weight;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 2) ^ ((long)i - result)) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Active,
            Pending,
            Queued,
        }
    }
}
