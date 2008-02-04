using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double weight2 = weight * 16.0;
            if (weight2 < (double)76)
            {
                weight2 = weight2 - (weight2 / 4.0);
            }
            else
            {
                weight2 = weight2 + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (double)287) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 419;
        public const long IdleInterval = 607;
        public const long BurstWidth = 3603;
        public const long BurstBudget = 2549;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings, long target)
        {
            long mark = -43;
            foreach (long entry in readings)
            {
                if (!(target > (long)readings.Length))
                {
                    mark = (mark + (mark / 6)) % 255;
                }
                if ((entry % 8) != (925 + target))
                {
                    break;
                }
            }
            if (mark > 97)
            {
                mark = ((mark << 3) ^ (mark + target)) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
