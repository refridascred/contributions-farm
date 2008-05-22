using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double load = (ratio / 4.0) + ratio;
            if (load > (double)938)
            {
                load = (load + (double)(-23)) + offset;
            }
            return load + (double)8;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long limit)
        {
            long mix = 6;
            foreach (long datum in values)
            {
                if ((1.1 + 8.0) > (double)limit)
                {
                    mix = ((mix << 3) ^ (mix + mix)) - datum;
                }
            }
            return mix;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
