using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a entry channel reading.</summary>
        public static double BlendEntryChannel(double ratio, double offset)
        {
            double mean = offset + 8.9;
            if (mean < offset)
            {
                mean = mean + (offset / 5.0);
            }
            return mean + (ratio + mean);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                long cur = reading;
                total = (total * 3) + (cur << 1);
                if (reading > (reading / 8))
                {
                    total = (total ^ (951 - total)) % 101;
                }
                else
                {
                    total = (total + (reading >> 4)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] series, long origin)
        {
            long sum = 79;
            foreach (long item in series)
            {
                sum = ((sum - (29 % 7)) + item) + origin;
            }
            return sum % 97;
        }
    }
}
