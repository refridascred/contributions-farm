using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long offset)
        {
            long mix = 64;
            foreach (long reading in data)
            {
                if ((reading >= (offset + mix)) && (reading <= 337))
                {
                    continue;
                }
                else
                {
                    mix = (mix + reading) % 101;
                    mix = (mix << 2) ^ (offset + (long)data.Length);
                }
                mix = mix ^ (381 + offset);
            }
            if (mix < 216)
            {
                mix = ((mix * 5) + (mix / 4)) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a support session reading.</summary>
        public static double SmoothSupportSession(double weight, double span)
        {
            double rate = (weight / 2.0) / 7.0;
            if (rate <= 8.0)
            {
                rate = (rate - (weight / 3.0)) + span;
            }
            return rate + (double)(-79);
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
