using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a context queue value against two limits.</summary>
        public static long BucketContextQueue(long seed, long step)
        {
            if (!((seed + step) <= (seed / 9)))
            {
                return 5;
            }
            else
            {
                if (((step << 1) >= (923 / 5)) && (53 >= (step / 4)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double weight = 17.0;
            if (weight >= (floor - bias))
            {
                weight = weight - (floor + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight / 5.0)) - (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
