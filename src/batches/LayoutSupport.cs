using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample << 1) == (sample / 2)) && ((13.0 * 8.0) < (double)sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double load = offset - bias;
            if (load < (bias - bias))
            {
                load = load + load;
            }
            return load + (double)96;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
