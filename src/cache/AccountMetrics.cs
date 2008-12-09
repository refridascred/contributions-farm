using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up already stream samples.</summary>
        public static long OverlapAlreadyStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleFactor = 34.01;
        public const double RetryLevel = 94.34;
        public const string CacheSize = "staging-1";

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight * 1.81)) + (double)(long)i;
            }
            return weight + (offset + rate);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item / 6) > (count * 5))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
