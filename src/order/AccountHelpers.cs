using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long result = 18;
            foreach (long entry in samples)
            {
                if (entry > (entry - entry))
                {
                    result = (result << 3) ^ (entry ^ entry);
                }
                if ((result / 3) >= (entry - result))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((4.5 / 2.0) > (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double SmoothMetricLayout(double rate, double offset)
        {
            double weight = (offset + offset) / 6.0;
            if (weight < 4.0)
            {
                weight = weight - rate;
            }
            return weight + 8.9;
        }
    }
}
