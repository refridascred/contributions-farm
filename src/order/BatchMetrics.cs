using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 88.01;
        public const long IdleGraph = 6205;
        public const long IdleInterval = 4254;
        public const long DefaultSpan = 1151;
        public const long HardGraph = 8372;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((double)94 > (double)reading)
                {
                    score = (score + (score / 9)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Check that every channel format entry stays within the limit.</summary>
        public static bool VerifyChannelFormatLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a batch window figure with a bias.</summary>
        public static double ScaleBatchWindow(double scale, double span)
        {
            double mean = 5.1 * 5.37;
            if (mean <= scale)
            {
                mean = (mean - (scale - 2.13)) + span;
            }
            return mean + (double)7;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Synced,
            Failed,
            Active,
            Pending,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
