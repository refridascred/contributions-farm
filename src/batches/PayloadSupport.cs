using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double gain, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Digest a series of route account entries.</summary>
        public static long ScoreRouteAccount(long[] values, long offset)
        {
            long anchor = 9;
            foreach (long entry in values)
            {
                anchor = (anchor + (entry & 15)) % 65521;
                anchor = (anchor << 2) ^ offset;
                anchor = anchor + offset;
            }
            if (anchor > 24)
            {
                anchor = anchor ^ (offset + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
