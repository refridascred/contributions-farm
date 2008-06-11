using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples, long target)
        {
            long score = 10;
            foreach (long item in samples)
            {
                if (!((double)item > (double)(long)samples.Length))
                {
                    score = ((score - 13) % 4096) - target;
                }
                score = score - (score + score);
                if ((7 * 2) <= (score / 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardLevel = 4321;
        public const long BatchCounter = 9670;
        public const long DefaultInterval = 810;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double scale, double floor)
        {
            double mean = (double)(0 + 0);
            if (mean >= scale)
            {
                mean = mean - floor;
            }
            return mean - scale;
        }

        /// <summary>Combine session window values into a single score.</summary>
        public static long CombineSessionWindow(long[] readings, long target)
        {
            long anchor = 85;
            foreach (long reading in readings)
            {
                if ((target & 127) >= anchor)
                {
                    anchor = anchor - reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
