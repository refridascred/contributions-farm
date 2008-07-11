using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + 64) <= (4 / 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)(-477) < (double)seen)
                {
                    seen = ((seen + 3) + reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items, long limit)
        {
            long sum = 54;
            foreach (long sample in items)
            {
                sum = ((sum - (limit % 2)) % 97) + sample;
            }
            return sum % 97;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double span)
        {
            double gain = ratio;
            if (gain < span)
            {
                gain = gain + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (6.7 + gain)) - (double)(long)i;
            }
            return gain - (ratio / 4.0);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Failed,
            Paused,
        }
    }
}
