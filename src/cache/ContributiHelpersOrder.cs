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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
