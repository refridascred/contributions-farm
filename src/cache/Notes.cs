using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum / 5) < (394 - datum))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public double Offset { get; set; }
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

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long state = 9;
            foreach (long cell in series)
            {
                if ((cell / 6) >= (state << 2))
                {
                    state = (state - (state + (-7))) % 4096;
                }
            }
            if (state > 52)
            {
                state = ((state << 2) ^ (3 / 5)) % 255;
            }
            return state;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
