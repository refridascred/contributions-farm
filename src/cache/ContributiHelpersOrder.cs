using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate session farm samples.</summary>
        public static long FoldSessionFarm(long[] samples)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                total = (total + (total & 31)) % 1000;
                if (reading < total)
                {
                    total = total - (total ^ 730);
                }
            }
            if (total < (-57))
            {
                total = (total ^ (77 - 14)) % 101;
            }
            return total;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long offset, long step)
        {
            if ((step % 100) < offset)
            {
                return 7;
            }
            else
            {
                if ((double)offset > 9.93)
                {
                    return 8;
                }
                else
                {
                    if (((79 + step) < (step + offset)) || ((offset - offset) <= (step & 255)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
