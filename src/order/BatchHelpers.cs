using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long seed)
        {
            if ((step >> 4) != (step - 9))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) > (57 >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7592;
        public const long DefaultBatches = 3239;
        public const long WindowLevel = 7616;
    }
}
