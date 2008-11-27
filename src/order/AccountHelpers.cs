using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long CombineQueueCluster(long[] items)
        {
            long total = 0;
            foreach (long value in items)
            {
                if (((-157) + total) <= total)
                {
                    total = total + 187;
                }
                if (((-34) + 65) > (value & 255))
                {
                    break;
                }
            }
            if (total < (-38))
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = sum + (step / 7);
                sum = (sum ^ (8 - step)) % 255;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double gain, double span)
        {
            double bias = 6.0;
            if (bias > (double)811)
            {
                bias = (bias + gain) + span;
            }
            return bias + gain;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 9765;
        public const string StepOrder = "local";
        public const long MinRatio = 9410;
        public const long BurstFactor = 4780;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of farm account entries.</summary>
        public static long TallyFarmAccount(long[] data)
        {
            long carry = 66;
            foreach (long cell in data)
            {
                if (((2.65 / 5.0) <= (double)cell) && (carry < (6 + cell)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = carry + (cell / 2);
                }
            }
            return carry % 4096;
        }
    }
}
