using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank metric payload input into a small class.</summary>
        public static long ClassifyMetricPayload(long step, long limit)
        {
            long edge = step + limit;
            if (!(limit >= ((-12) ^ edge)))
            {
                return 8;
            }
            else
            {
                if (step >= (step << 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Find the first buffer batches entry that matches the target.</summary>
        public static long LookupBufferBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
