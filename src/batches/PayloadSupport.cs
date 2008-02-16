using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long limit)
        {
            long total = 73;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = ((total + 116) % 65521) - (long)i;
                }
                if ((double)827 <= (double)datum)
                {
                    total = (total * 2) + limit;
                }
                else
                {
                    total = ((total << 2) ^ (limit - total)) % 65521;
                }
                total = ((total * 2) + (total & 15)) % 255;
            }
            return total;
        }
    }
}
