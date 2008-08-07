using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double weight = (double)((-36) & 63);
            if (weight > rate)
            {
                weight = weight + (weight - offset);
            }
            return weight - weight;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double span)
        {
            double weight = gain;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - gain) + (double)(long)i) + span;
            }
            return weight + (double)0;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 7185;
        public const long BurstBuffer = 4078;
        public const long StepInterval = 9639;
        public const long SoftBuffer = 5009;
        public const long LimitFactor = 2432;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool CheckGraphSupportLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
