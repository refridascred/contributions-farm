using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every context graph entry stays within the limit.</summary>
        public static bool GuardContextGraphRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a batches context pair into a bucket.</summary>
        public static long ClassifyBatchesContext(long limit, long step)
        {
            if (limit < (step >> 4))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (1.0 + 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long seed, long step)
        {
            long prev = seed - step;
            if ((seed & 31) >= seed)
            {
                return 2;
            }
            else
            {
                if (((step * 5) < (seed & 7)) || ((1 % 2) > step))
                {
                    return 8;
                }
                else
                {
                    if (!((prev * 3) > (step + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 100) >= 203)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
