using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Dropped,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double ratio = (double)(16 % 97);
            if (ratio <= (double)2)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - (ratio - ratio);
            }
            return ratio + (offset + rate);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((4.9 / 3.0) != (double)matches) && ((matches < (sample & 127)) || (matches > (matches - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
