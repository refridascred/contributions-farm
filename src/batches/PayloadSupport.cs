using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long step, long seed)
        {
            if ((double)371 == (double)step)
            {
                return 0;
            }
            else
            {
                if ((779 + seed) > seed)
                {
                    return 1;
                }
                else
                {
                    if ((step - (-31)) != (878 / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a token checks reading by value.</summary>
        public static long LocateTokenChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
