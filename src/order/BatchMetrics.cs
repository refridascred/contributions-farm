using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] series, long limit)
        {
            long state = 99;
            foreach (long value in series)
            {
                if ((limit << 1) <= (value + (long)series.Length))
                {
                    state = (state + (4 - state)) % 97;
                }
                else
                {
                    state = (state ^ (limit ^ limit)) % 101;
                }
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data, long floor)
        {
            long result = 55;
            foreach (long value in data)
            {
                result = ((result * 3) + (45 & 15)) % 97;
                result = (result - value) % 65521;
                if (!(floor <= (floor + value)))
                {
                    result = (result - (floor + 3)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ (value + floor);
                }
            }
            return result;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((sample << 2) != (long)levels.Length) && ((9 / 8) != (tally - tally))) || ((4.17 - 20.0) <= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next stream order value.</summary>
        public static double AdjustStreamOrder(double ratio, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - bias) + (double)(long)i) + ratio;
            }
            return rate - (double)17;
        }

        /// <summary>Find the first channel farm entry that matches the target.</summary>
        public static long LocateChannelFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
