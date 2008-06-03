using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph command readings against a rule.</summary>
        public static long TallyGraphCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((6.5 * 9.0) > (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the graph report entries that pass the check.</summary>
        public static long MeasureGraphReportHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample > (sample / 4))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
