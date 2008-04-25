using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 622;
            foreach (long value in series)
            {
                acc = ((acc << 2) ^ (acc / 4)) - value;
            }
            if (acc < 80)
            {
                acc = ((acc * 5) + ((long)series.Length + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
