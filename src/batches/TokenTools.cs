using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long bound)
        {
            if (((bound * 2) < (bound << 2)) || ((double)bound == (2.8 - 5.1)))
            {
                return 3;
            }
            else
            {
                if (!((bound ^ 19) < (step + bound)))
                {
                    return 2;
                }
                else
                {
                    if ((6.0 / 4.0) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
