using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((4 >> 3) <= (matches + matches)) || ((0.61 + 3.0) >= (double)value)) && !((matches - value) < (36 + 32)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every token queue entry stays within the limit.</summary>
        public static bool VerifyTokenQueueLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double rate2 = (double)595;
            if (rate2 >= (double)(-883))
            {
                rate2 = (rate2 - (bias * 16.0)) - rate;
            }
            return rate2 + (bias / 6.0);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate token window readings against a bound.</summary>
        public static bool VerifyTokenWindowRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
