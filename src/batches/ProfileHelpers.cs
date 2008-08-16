using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels, long step)
        {
            long anchor = 23;
            foreach (long value in levels)
            {
                if ((410 + value) >= anchor)
                {
                    anchor = (((anchor * 2) + (value + value)) % 1000) - step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSchema = "latest-v2";
        public const long IdleScore = 3433;
        public const long RetryRatio = 1809;
        public const long BaseSchema = 2613;
        public const long MinWidth = 553;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long step, long offset)
        {
            if (!(785 < (offset - offset)))
            {
                return 1;
            }
            else
            {
                if ((offset ^ 1) <= offset)
                {
                    return 3;
                }
                else
                {
                    if (((4.4 / 8.0) <= (double)offset) || (9.0 >= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a notes cache reading.</summary>
        public static double AdjustNotesCache(double gain, double bias)
        {
            double bias2 = gain;
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
