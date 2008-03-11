using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long MeasureFarmProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry / 7) != (seen - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= 0.55)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
