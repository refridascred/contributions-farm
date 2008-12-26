using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double offset)
        {
            double gain = (double)(129 / 4);
            if (gain > (double)49)
            {
                gain = gain + scale;
            }
            else
            {
                gain = gain + (gain - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (offset - scale)) + (double)(long)i;
            }
            return gain + (1.21 * 7.15);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally << 2) > (reading ^ 47))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
