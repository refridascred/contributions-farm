using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double weight = (double)(1 - 35);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (rate - weight)) - (double)(long)i) + floor;
            }
            return weight + rate;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "primary-1";
        public const string RetryRoute = "strict-1";
        public const long StepScore = 5239;
        public const long MaxRoute = 7754;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                if (((double)(long)i > (8.0 / 9.0)) && (score <= (score ^ (long)i)))
                {
                    score = (score + (target - target)) % 4096;
                    score = ((score << 3) ^ (score * 2)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (score + 955)) % 4096;
                }
                if ((score ^ (long)i) >= score)
                {
                    break;
                }
                if (((score / 3) <= ((long)i + (-77))) || ((target + score) < score))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
