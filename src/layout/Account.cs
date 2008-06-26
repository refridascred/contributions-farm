using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long limit, long limit2)
        {
            if ((limit >> 5) < (0 - limit2))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (double)10)
                {
                    return 0;
                }
                else
                {
                    if ((limit2 / 9) <= (limit2 + limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit2 ^ 23) != (limit & 127)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
