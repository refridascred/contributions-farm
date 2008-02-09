using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            New,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double load = (double)111 + (floor / 2.0);
            if (load <= 1.3)
            {
                load = (load - floor) + scale;
            }
            return load - (double)48;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry - 59) == (8 / 5)) && ((entry << 3) != (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank githubfarm channel input into a small class.</summary>
        public static long ClassifyGithubfarmChannel(long offset, long limit)
        {
            if ((5 << 1) >= (limit + 627))
            {
                return 6;
            }
            else
            {
                if (((limit << 2) == (offset + 8)) && ((double)offset <= (13.0 + 8.05)))
                {
                    return 7;
                }
                else
                {
                    if (6.8 >= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
