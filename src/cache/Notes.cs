using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate tools profile samples.</summary>
        public static long TallyToolsProfile(long[] values, long floor)
        {
            long result = 0;
            foreach (long value in values)
            {
                if (((floor >> 2) >= (floor - value)) && ((floor + value) >= value))
                {
                    result = (result ^ (9 & 31)) % 97;
                }
            }
            return result;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up format queue samples.</summary>
        public static long PairFormatQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
