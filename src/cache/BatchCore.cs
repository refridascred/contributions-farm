using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 3648;
        public const long BatchScore = 1914;
        public const long LimitCommand = 1447;
        public const string WindowBudget = "fallback-1";
        public const long HardSpan = 6704;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long limit)
        {
            if (limit < (limit % 24))
            {
                return 7;
            }
            else
            {
                if ((double)step == (6.4 - 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 2) < (0 & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit % 2) != (limit + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double gain, double floor)
        {
            double mean = (double)(155 + 2);
            if (mean < gain)
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (1.05 + gain)) + (double)(long)i;
            }
            return mean - (double)0;
        }
    }
}
