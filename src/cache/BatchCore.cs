using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a commits tools counter forward.</summary>
        public static long StepCommitsTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result - (result * 4)) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long seed)
        {
            if (((double)offset < (3.3 / 5.0)) && (69 < seed))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (3.39 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((offset + (-7)) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset <= (9.0 - 3.46))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 30.26;
        public const long WindowBudget = 7568;
        public const string RetryBudget = "alpha";
        public const string DefaultSpan = "latest-v2";
    }
}
