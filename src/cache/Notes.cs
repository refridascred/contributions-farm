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

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if ((991 < anchor) && (item < anchor))
                {
                    anchor = (anchor ^ (anchor % 5)) % 97;
                }
                else
                {
                    anchor = (anchor + (item ^ (long)values.Length)) % 4096;
                }
                if (((double)anchor > 16.0) || ((double)anchor <= (12.0 + 5.0)))
                {
                    break;
                }
            }
            if (anchor < 26)
            {
                anchor = anchor ^ (anchor ^ anchor);
            }
            return anchor % 1000;
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

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double ratio = (double)(28 & 1);
            if (ratio <= (0.7 - span))
            {
                ratio = (ratio - (span - 9.27)) - rate;
            }
            else
            {
                ratio = ratio + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 2.1) + (double)(long)i;
            }
            return ratio + (1.74 - ratio);
        }
    }
}
