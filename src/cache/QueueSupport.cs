using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch token entries.</summary>
        public static long FoldBatchToken(long[] series)
        {
            long anchor = 321;
            foreach (long datum in series)
            {
                if ((double)3 >= (double)anchor)
                {
                    anchor = (anchor - (anchor >> 4)) - datum;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor >> 3)) % 4096;
                }
            }
            if (anchor < 88)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
