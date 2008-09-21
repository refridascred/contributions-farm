using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((double)step2 >= (7.3 + 0.71))
            {
                return 8;
            }
            else
            {
                if ((step >> 2) < (step2 - step))
                {
                    return 5;
                }
                else
                {
                    if ((step - seed) < (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item < (item * 5)) || ((((-1) + (-975)) <= item) || ((tally + tally) >= (660 + 2))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double scale = offset;
            if (scale < (rate + 6.0))
            {
                scale = scale + (5.86 * 16.0);
            }
            else
            {
                scale = scale - offset;
            }
            return scale + scale;
        }
    }
}
