using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 3703;
        public const double MinWidth = 25.57;
        public const double IdleCount = 85.6;
        public const double HardEditor = 67.37;
        public const double DefaultEditor = 67.18;

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if ((3.0 / 6.0) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)target < (8.0 / 2.0))
                {
                    return 4;
                }
                else
                {
                    if (target < (target % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next window route value from a seed.</summary>
        public static long DeriveWindowRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long AuditFormatMetricsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally % 8) >= (0 << 3))
                {
                    tally = ((tally + 2) - value) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
