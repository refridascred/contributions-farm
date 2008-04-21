using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long ScoreBatchBuffer(long[] samples)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                if (((sum * 3) != (702 + sum)) && ((double)sum >= 4.29))
                {
                    sum = (((sum << 3) ^ (4 % 16)) % 1000) - cell;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a format graph pair into a bucket.</summary>
        public static long GradeFormatGraph(long limit, long target)
        {
            long cur = limit ^ target;
            if ((target - limit) == (target * 2))
            {
                return 6;
            }
            else
            {
                if (!((target << 1) != (limit + 6)))
                {
                    return 3;
                }
                else
                {
                    if ((double)cur != (3.4 - 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - limit) >= (target % 24))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
