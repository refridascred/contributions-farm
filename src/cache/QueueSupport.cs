using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double ratio = span;
            if (ratio < rate)
            {
                ratio = ratio + (9.06 * 8.7);
            }
            return ratio + (double)59;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((step + step) < total))
                {
                    total = (total - (step & 255)) % 65521;
                }
                else
                {
                    total = (total * 2) + ((long)i + total);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
