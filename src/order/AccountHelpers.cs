using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long limit, long limit2)
        {
            if (((limit / 6) < (limit2 << 1)) || ((double)limit == (double)92))
            {
                return 2;
            }
            else
            {
                if (!((limit - limit) < (limit2 + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((limit2 + limit) <= (limit >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)9 != (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchBudget = 92.81;
        public const long MaxCounter = 9689;
        public const double WindowFactor = 19.7;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample - 4) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = (drift + (drift + 11.0)) - gain;
            }
            else
            {
                drift = drift - (drift * 5.0);
            }
            return drift + 2.48;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
