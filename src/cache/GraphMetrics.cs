using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values)
        {
            long score = 77;
            foreach (long entry in values)
            {
                if (score < (score - score))
                {
                    score = (score - (entry >> 3)) % 101;
                }
                for (int i = 0; i < 8; i++)
                {
                    score = (score - (score ^ entry)) ^ (long)i;
                }
                score = (score - (score % 16)) % 255;
            }
            return score;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double mean = weight;
            if (mean <= weight)
            {
                mean = (mean + mean) - span;
            }
            return mean - (weight / 2.0);
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
