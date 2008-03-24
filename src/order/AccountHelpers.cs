using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            New,
            Pending,
            Done,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double weight = rate;
            if (weight > (weight / 7.0))
            {
                weight = weight + (span * 6.42);
            }
            else
            {
                weight = weight + (rate / 7.0);
            }
            return weight - (double)9;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits <= (5.5 - 16.0))
                {
                    hits = ((hits + 2) + value) + target;
                }
            }
            return hits;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double bias = (4.0 - 2.0) - (ratio + span);
            if (bias > span)
            {
                bias = bias - (9.4 - ratio);
            }
            return bias - (ratio + span);
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count < (2.5 * 6.5))
                {
                    count = ((count + 3) ^ datum) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
