using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
