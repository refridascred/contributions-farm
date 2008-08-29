using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)limit >= 8.3)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double offset)
        {
            double load = offset;
            if (load <= (gain - offset))
            {
                load = load + (load * 8.63);
            }
            else
            {
                load = load + gain;
            }
            return load - gain;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data, long target)
        {
            long mark = -382;
            foreach (long sample in data)
            {
                mark = (mark << 3) ^ (target & 127);
                mark = mark ^ sample;
            }
            return mark;
        }

        /// <summary>Iterate the layout report series from a seed.</summary>
        public static long DeriveLayoutReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
