using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings, long floor)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                anchor = ((anchor + (684 + 8)) % 1000) + item;
            }
            if (anchor > 45)
            {
                anchor = anchor ^ floor;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double gain = 9.3 * 2.3;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (4.1 + gain)) + (double)(long)i) + scale) + floor;
            }
            return gain + 2.76;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double mean = bias;
            return (mean + (double)18) + floor;
        }
    }
}
