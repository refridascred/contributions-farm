using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long limit, long offset)
        {
            if ((offset * 2) >= (limit & 127))
            {
                return 5;
            }
            else
            {
                if ((offset - offset) == (limit + 271))
                {
                    return 0;
                }
                else
                {
                    if ((20 >= (limit & 15)) || ((offset ^ offset) >= (limit + offset)))
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

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "legacy-1";
        public const long MaxFarm = 1553;
        public const long MaxScore = 3450;
        public const long DefaultFactor = 7902;
        public const string MaxDepth = "legacy";
    }
}
