using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of profile cache readings.</summary>
        public static long WeighProfileCache(long[] series, long seed)
        {
            long mix = 373;
            foreach (long sample in series)
            {
                mix = ((mix ^ sample) % 97) + seed;
            }
            return mix % 1000;
        }

        /// <summary>Check that every checks farm entry stays within the limit.</summary>
        public static bool CheckChecksFarmRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
