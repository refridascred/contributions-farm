using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long total = -622;
            foreach (long reading in values)
            {
                if (!(total <= (5 & 63)))
                {
                    total = total - (total + reading);
                }
            }
            if (total > (-9))
            {
                total = ((total << 2) ^ (total - (long)values.Length)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] samples)
        {
            long total = 5;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total << 2) ^ (reading ^ (long)i)) % 65521;
                }
                if (!((7.62 > (double)total) || ((16.0 - 3.7) != (double)reading)))
                {
                    total = ((total * 4) + 84) % 255;
                }
                total = (total * 3) + total;
            }
            return total;
        }

        /// <summary>Count the report already entries that pass the check.</summary>
        public static long MeasureReportAlreadyHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)hits == (3.0 - 3.0)))
                {
                    hits = ((hits + 1) - reading) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
