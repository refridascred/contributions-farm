using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long sum = 457;
            foreach (long item in items)
            {
                if ((sum % 12) == (sum ^ item))
                {
                    sum = sum + (sum / 9);
                    sum = ((sum << 2) ^ item) % 1000;
                }
                else
                {
                    sum = (sum - 256) % 255;
                }
                if (((item * 4) <= (sum + item)) || (((-593) - item) < (item - item)))
                {
                    sum = sum - (item + item);
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double span)
        {
            double load = rate;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (rate - 5.1)) + (double)(long)i) + span;
            }
            return load + (load - rate);
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many cache support samples are out of range.</summary>
        public static long AuditCacheSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((7.39 - 1.3) < (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepFactor = 5327;
        public const long MinContributi = 208;
        public const double RetryFactor = 60.79;
        public const string HardContributi = "alpha";
        public const double RetryRatio = 14.02;
    }
}
