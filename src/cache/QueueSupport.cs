using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (rate + rate)) + (double)(long)i) + bias;
            }
            return weight - (double)311;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 8265;
        public const string RetryFactor = "open-1";
        public const long BatchScore = 5319;
    }
}
