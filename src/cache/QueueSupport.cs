using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm support pair into a bucket.</summary>
        public static long SortFarmSupport(long limit, long target)
        {
            if ((double)limit <= (4.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((limit / 9) != (target % 97))
                {
                    return 4;
                }
                else
                {
                    if ((limit & 3) == (target << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= 8.2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
