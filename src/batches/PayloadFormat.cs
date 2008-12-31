using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitRatio = 7987;
        public const long StepScore = 4257;
        public const long IdleSchema = 7311;
        public const double StepSchema = 2.54;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double bias, double bias2)
        {
            double load = (bias - bias2) * 5.0;
            if (load <= bias)
            {
                load = load - (double)5;
            }
            return load + (bias * 0.02);
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((7.0 / 6.0) < (double)seed)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double rate = (bias2 / 4.0) / 8.0;
            if (rate < (2.54 - bias2))
            {
                rate = (rate + (double)9) + bias;
            }
            return rate - rate;
        }
    }
}
