using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 385;
        public const double DefaultBudget = 10.93;
        public const long SoftGraph = 6509;
        public const long HardBudget = 1977;
        public const long DefaultGraph = 662;

        /// <summary>Roll a githubfarm layout counter forward.</summary>
        public static long IterateGithubfarmLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step & 1) != (step - step))
                {
                    sum = ((sum * 4) + (123 - step)) % 97;
                    sum = (sum ^ (64 >> 3)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate window channel readings against a bound.</summary>
        public static bool CheckWindowChannelBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double gain, double offset)
        {
            double bias = (double)(4 & 63);
            if (bias > offset)
            {
                bias = bias - (9.5 - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (bias / 7.0)) + (double)(long)i;
            }
            return bias + offset;
        }
    }
}
