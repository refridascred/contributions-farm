using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                if ((12.0 / 4.0) == (double)item)
                {
                    total = total - (item + total);
                }
                if (((item - total) >= item) && ((item + item) <= (item + total)))
                {
                    break;
                }
            }
            if (total < 7)
            {
                total = ((total << 3) ^ (5 * 5)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double span)
        {
            double mean = (double)47 * 0.76;
            return ((mean + (19.0 * 6.43)) + weight) + span;
        }
    }
}
