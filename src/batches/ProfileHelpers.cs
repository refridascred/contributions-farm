using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    long step2 = (long)i >> 3;
                    carry = ((carry - (step2 >> 1)) % 101) ^ (long)i2;
                }
                if (!((carry + 68) > (carry + step)))
                {
                    carry = (carry + 7) % 101;
                }
                carry = ((carry * 3) + (176 >> 3)) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double bias)
        {
            double weight = bias;
            if (weight <= (double)(-863))
            {
                weight = (weight - 10.0) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepRatio = 3399;
        public const long MaxEntry = 477;
        public const string CacheRatio = "legacy-edge";
        public const double DefaultTimeout = 2.65;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 1866;
        public const long BaseCounter = 4310;
        public const long WindowCounter = 3894;
        public const long SoftScore = 1921;
        public const long DefaultCounter = 6219;
    }
}
