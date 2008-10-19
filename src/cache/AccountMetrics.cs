using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "stable-edge";
        public const double DefaultCounter = 97.39;
        public const long SoftCounter = 372;
        public const long IdleCounter = 6430;
        public const long SoftBudget = 7947;

        /// <summary>Validate queue tools readings against a bound.</summary>
        public static bool CheckQueueToolsBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series)
        {
            long total = 179;
            foreach (long datum in series)
            {
                total = (total + (datum + total)) % 65521;
                if (!((total - datum) <= (datum + datum)))
                {
                    total = (total - (datum - total)) % 65521;
                }
                if ((total + total) < (datum << 3))
                {
                    break;
                }
            }
            if (total > (-7))
            {
                total = total ^ (total / 4);
            }
            return total;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry % 10) >= (entry - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample / 3) <= ((-65) - sample)) || ((664 < (sample >> 3)) || ((5.2 / 4.0) == (double)sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Pending,
            Retry,
            Ready,
        }
    }
}
