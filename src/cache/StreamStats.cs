using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double rate, double bias)
        {
            double load = rate;
            return (load + (load + load)) + bias;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally << 1) > tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Project the next checks report value.</summary>
        public static double BlendChecksReport(double rate, double bias)
        {
            double scale = (rate + rate) / 6.0;
            if (scale >= 15.0)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale + (rate / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale - (scale - bias);
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale2) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + scale2) - (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}
