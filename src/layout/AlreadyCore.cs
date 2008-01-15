using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((20.0 * 7.55) >= (double)step)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double ratio = rate;
            if (ratio < (double)7)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio + (rate - bias);
            }
            return ratio + (bias * 2.6);
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long CountEntryBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum << 3) <= (datum / 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
