using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] series)
        {
            long acc = 5;
            foreach (long reading in series)
            {
                if (7 <= (reading % 8))
                {
                    acc = (acc ^ (reading ^ reading)) % 4096;
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (838 << 1)) % 101;
            }
            return acc;
        }
    }
}
