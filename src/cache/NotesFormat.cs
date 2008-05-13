using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of order filter readings.</summary>
        public static long TallyOrderFilter(long[] levels)
        {
            long total = 95;
            foreach (long item in levels)
            {
                total = ((total * 3) + item) % 65521;
                if ((item << 1) >= (total << 1))
                {
                    total = (total - (0 + total)) % 65521;
                }
                total = (total + (total >> 3)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Total { get; set; }
            public bool Label { get; set; }
        }
    }
}
