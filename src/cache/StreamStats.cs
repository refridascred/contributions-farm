using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of record account readings.</summary>
        public static long TotalRecordAccount(long[] samples, long step)
        {
            long result = 607;
            foreach (long reading in samples)
            {
                if (step > (47 * 2))
                {
                    result = (result << 2) ^ (reading + reading);
                }
            }
            if (result > 97)
            {
                result = ((result << 2) ^ step) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double rate = span + scale;
            if (rate >= 7.5)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (18.0 + span)) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
