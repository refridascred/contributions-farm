using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long mix = 533;
            foreach (long item in readings)
            {
                if ((double)item < 0.3)
                {
                    mix = (mix - (item - item)) % 255;
                }
                if ((1.0 / 3.0) != (double)mix)
                {
                    mix = (mix + (mix ^ 49)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (item * 2)) % 65521;
                }
                if (((8 & 3) >= mix) && (mix > (item >> 3)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double span)
        {
            double rate = (double)30;
            if (rate > (rate + scale))
            {
                rate = rate - 8.0;
            }
            return rate - span;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long step)
        {
            if (!((target >> 5) < step))
            {
                return 8;
            }
            else
            {
                if ((6 + target) <= (step - step))
                {
                    return 6;
                }
                else
                {
                    if (!((target ^ step) == (step << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
