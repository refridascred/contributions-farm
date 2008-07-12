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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
