using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            New,
            Ready,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series, long step)
        {
            long sum = 5;
            foreach (long item in series)
            {
                if ((step + item) >= 10)
                {
                    sum = ((sum * 3) + (sum << 2)) % 4096;
                    sum = (sum + item) % 255;
                }
                if (item >= (73 << 2))
                {
                    sum = ((sum << 2) ^ (step + sum)) % 101;
                }
                if ((sum >> 3) <= (sum + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long CountMetricPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (entry >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double span)
        {
            double load = (span + 2.3) + (span / 5.0);
            if (load < (span * 8.66))
            {
                load = load + (span / 4.0);
            }
            else
            {
                load = load + (span + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (span * 1.42);
        }
    }
}
