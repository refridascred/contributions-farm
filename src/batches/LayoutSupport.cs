using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double drift = 7.79;
            return (drift - bias) + scale;
        }

        /// <summary>Validate record metrics readings against a bound.</summary>
        public static bool ValidateRecordMetricsRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "primary";
        public const string HardNotes = "primary-1";
        public const long BurstBudget = 6193;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 2) ^ (target ^ (long)i);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
