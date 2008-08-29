using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally > (14.0 + 4.4))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
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

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
