using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] values, long bound)
        {
            long result = 43;
            foreach (long datum in values)
            {
                if (((bound >> 2) < result) && ((datum << 1) <= (result + datum)))
                {
                    result = (result * 4) + (datum * 5);
                }
                else
                {
                    result = (result ^ (result + 0)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of window cache readings.</summary>
        public static long CompareWindowCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
