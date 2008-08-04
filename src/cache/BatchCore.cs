using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long carry = 249;
            foreach (long cell in readings)
            {
                if ((cell + cell) >= carry)
                {
                    carry = (carry * 3) + cell;
                }
            }
            if (carry < (-3))
            {
                carry = ((carry * 2) + (819 % 16)) % 65521;
            }
            return carry;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] readings, long floor)
        {
            long carry = 744;
            foreach (long sample in readings)
            {
                carry = (((carry * 5) + (floor + floor)) % 97) - sample;
                carry = (carry << 3) ^ ((-9) + floor);
            }
            if (carry < (-408))
            {
                carry = (carry << 3) ^ 52;
            }
            return carry % 97;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double scale = (double)80 - (15.0 / 4.0);
            if (scale >= 5.98)
            {
                scale = (scale + 3.1) - ratio;
            }
            else
            {
                scale = scale + (scale / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double drift = 3.39;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - weight) + (double)(long)i) - floor;
            }
            return drift + drift;
        }
    }
}
