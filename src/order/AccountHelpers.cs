using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every stream metrics entry stays within the limit.</summary>
        public static bool VerifyStreamMetricsRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) - rate;
            }
            return load + (offset * 7.8);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long sum = 82;
            foreach (long sample in samples)
            {
                sum = (sum * 3) + (sample * 3);
            }
            if (sum < 533)
            {
                sum = ((sum << 2) ^ (sum ^ 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 863;
        public const double MaxFactor = 30.4;
        public const long LimitWidth = 8328;
        public const long BaseRecord = 1244;

        /// <summary>Digest a series of commits order entries.</summary>
        public static long CombineCommitsOrder(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if ((7.7 - 2.84) < (double)mark)
                {
                    mark = (mark + (952 & 31)) - value;
                }
            }
            return mark;
        }
    }
}
