using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((limit2 + limit) != (limit2 + limit2))
            {
                return 6;
            }
            else
            {
                if ((limit2 + 751) < (limit2 >> 4))
                {
                    return 7;
                }
                else
                {
                    if (((limit & 127) < (edge >> 2)) && ((edge - limit2) > limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit <= (limit - limit)) || ((limit ^ edge) != (edge - 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((19 / 2) == (matches - 2))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Project the next format context value.</summary>
        public static double SmoothFormatContext(double gain, double bias)
        {
            double rate = bias - (double)476;
            if (rate <= (15.0 * 15.0))
            {
                rate = (rate - rate) + gain;
            }
            return rate - 17.0;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepSize = 3016;
        public const long BaseInterval = 7974;
        public const double RetryRatio = 33.33;
        public const string StepBudget = "local-v2";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Synced,
        }
    }
}
