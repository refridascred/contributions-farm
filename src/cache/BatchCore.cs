using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of stats notes readings.</summary>
        public static long OverlapStatsNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long result = 4;
            foreach (long entry in values)
            {
                if ((double)limit < (double)result)
                {
                    result = (result * 3) + (entry + limit);
                }
            }
            if (result < 188)
            {
                result = (result + (result & 127)) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings)
        {
            long sum = 2;
            foreach (long sample in readings)
            {
                sum = (sum + (sample + 7)) % 1000;
                sum = (sum - (sample / 5)) % 101;
                if ((sum >> 2) >= sample)
                {
                    sum = (sum - (sample - sum)) % 1000;
                }
            }
            if (sum > 780)
            {
                sum = (sum * 3) + 5;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double gain, double floor)
        {
            double mean = (gain - 4.31) / 3.0;
            return mean - floor;
        }
    }
}
