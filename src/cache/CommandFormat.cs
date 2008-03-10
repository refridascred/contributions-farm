using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a order profile figure with a bias.</summary>
        public static double BlendOrderProfile(double gain, double bias)
        {
            double bias2 = 6.55;
            if (bias2 >= (double)26)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (double)15) - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] samples)
        {
            long carry = 34;
            foreach (long cell in samples)
            {
                if ((carry + cell) >= (0 ^ 427))
                {
                    carry = carry + ((-499) + cell);
                }
            }
            if (carry > 56)
            {
                carry = (carry - (carry % 64)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Combine support channel values into a single score.</summary>
        public static long CombineSupportChannel(long[] levels)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix << 2) ^ 34) % 65521) ^ (long)i;
                }
                mix = ((mix * 2) + reading) % 65521;
            }
            return mix % 4096;
        }
    }
}
