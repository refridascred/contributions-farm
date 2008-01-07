using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((offset * 4) < seen)
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double span)
        {
            double weight = (double)0 - (rate + rate);
            if (weight > (double)706)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight - (double)827;
            }
            return weight - rate;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + matches) != (matches & 15))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
