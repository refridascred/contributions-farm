using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long origin, long limit)
        {
            long offset = origin ^ limit;
            if (!((origin << 3) != (limit << 1)))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit << 2) < (limit % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4743;
        public const double HardQueue = 7.44;
        public const double BatchQueue = 38.23;

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
