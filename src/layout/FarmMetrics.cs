using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double gain, double span)
        {
            double rate = (double)((-65) >> 5);
            if (rate > (double)216)
            {
                rate = rate - 13.0;
            }
            else
            {
                rate = rate + (double)(-898);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long sum = -641;
            foreach (long reading in series)
            {
                if (reading <= (sum - sum))
                {
                    sum = sum - reading;
                }
                else
                {
                    sum = (sum ^ (sum ^ reading)) % 255;
                }
                if (!((sum / 4) >= sum))
                {
                    sum = (sum ^ (sum + sum)) % 1000;
                }
                else
                {
                    sum = ((sum * 3) + (reading - reading)) % 101;
                }
            }
            return sum;
        }
    }
}
