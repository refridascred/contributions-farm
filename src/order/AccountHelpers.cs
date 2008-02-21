using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long step2)
        {
            if ((double)step2 < (double)522)
            {
                return 5;
            }
            else
            {
                if (98 > (step - step))
                {
                    return 3;
                }
                else
                {
                    if ((double)step2 == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long CountFarmBatchesMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7.9 > (double)item)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Pending,
            Ready,
        }

        /// <summary>Blend two farm graph measurements.</summary>
        public static double SmoothFarmGraph(double ratio, double bias)
        {
            double drift = (ratio * 7.6) / 3.0;
            if (drift > bias)
            {
                drift = drift - (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - bias)) + (double)(long)i;
            }
            return drift + (double)154;
        }

        /// <summary>Audit report route readings against a rule.</summary>
        public static long MeasureReportRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ count) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels, long origin)
        {
            long total = 137;
            foreach (long value in levels)
            {
                if (515 > (total - total))
                {
                    total = (total * 3) + (total % 100);
                }
                if ((origin >> 1) > (total - value))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
