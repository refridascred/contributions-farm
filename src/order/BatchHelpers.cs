using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long step)
        {
            if ((limit << 1) > step)
            {
                return 4;
            }
            else
            {
                if ((8.3 * 0.2) > (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (3.46 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step <= (2.46 / 3.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 68.52;
        public const long LimitDepth = 9456;
        public const long RetryInterval = 598;
        public const long MinCount = 3525;
    }
}
