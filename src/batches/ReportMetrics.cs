using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit counter format readings against a rule.</summary>
        public static long MeasureCounterFormatHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(((long)values.Length - value) > (count + count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the context order series from a seed.</summary>
        public static long DeriveContextOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(((mix * 3) == (mix * 4)) || ((14.0 + 1.61) > (double)(long)i)))
                {
                    mix = (mix - ((long)i - step)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
