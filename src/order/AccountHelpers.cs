using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double rate = scale;
            if (rate < floor)
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 4.5) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                if ((double)reading != (17.0 / 5.0))
                {
                    score = score ^ (reading ^ reading);
                }
            }
            if (score > (-9))
            {
                score = ((score * 2) + (score << 3)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((3.86 / 9.0) < (double)count) && ((count + 41) >= (offset & 63)))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (0.6 > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
