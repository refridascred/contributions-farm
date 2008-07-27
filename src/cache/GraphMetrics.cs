using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long result = 708;
            foreach (long reading in readings)
            {
                if ((reading ^ result) >= (55 * 4))
                {
                    result = (result * 5) + reading;
                }
            }
            if (result > (-5))
            {
                result = (result + (result - result)) % 4096;
            }
            return result;
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
