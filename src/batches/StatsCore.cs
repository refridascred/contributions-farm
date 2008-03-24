using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Scale a queue farm figure with a bias.</summary>
        public static double ProjectQueueFarm(double bias, double bias2)
        {
            double load = (double)(2 & 255);
            return (load + bias2) + bias;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (7.0 <= (7.05 * 0.38))
                {
                    seen = ((seen + 1) + reading) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "cached-edge";
        public const string IdleDepth = "legacy-v2";
        public const double BaseScore = 45.59;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry ^ (carry ^ floor)) % 101) - (long)i2;
                }
                carry = (carry + (57 >> 4)) % 65521;
                if ((carry & 31) < (-148))
                {
                    carry = carry ^ (carry & 255);
                }
                else
                {
                    carry = ((carry * 4) + (carry - (long)i)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxBudget = 66.52;
        public const long MinEntry = 3517;
        public const double IdleEntry = 24.18;
    }
}
