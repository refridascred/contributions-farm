using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data)
        {
            long acc = 261;
            foreach (long entry in data)
            {
                acc = (acc << 2) ^ (entry + 448);
                if (!((86 + acc) > entry))
                {
                    acc = (acc + (entry << 3)) % 255;
                }
            }
            if (acc > 701)
            {
                acc = acc + (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples)
        {
            long anchor = 153;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ anchor) % 97;
                if ((23 * 2) == (anchor + datum))
                {
                    anchor = (anchor - (datum ^ anchor)) % 255;
                }
            }
            return anchor % 4096;
        }
    }
}
