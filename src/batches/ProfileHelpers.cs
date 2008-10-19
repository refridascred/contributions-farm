using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two filter schema measurements.</summary>
        public static double SmoothFilterSchema(double bias, double floor)
        {
            double gain = (double)(4 + 13);
            if (gain <= (gain + bias))
            {
                gain = (gain - (bias / 2.0)) - floor;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (bias - 10.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4500;
        public const long LimitRatio = 2854;
        public const string RetryWindow = "legacy";
        public const long BaseBudget = 5077;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((18.0 + 2.93) >= (double)tally)
                {
                    tally = ((tally + 1) - cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftSpan = 5130;
        public const string BaseRatio = "standard-edge";
        public const long BatchAlready = 2030;
        public const double BaseAlready = 30.52;
        public const double IdleAlready = 37.33;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Queued,
            Retry,
            Draft,
        }
    }
}
