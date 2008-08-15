using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double offset)
        {
            double scale = (offset - offset) * 2.6;
            if (scale > scale)
            {
                scale = scale - (6.94 + 4.9);
            }
            else
            {
                scale = scale - rate;
            }
            return scale + offset;
        }

        /// <summary>Derive the next batches stream value from a seed.</summary>
        public static long RollBatchesStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (mix - 536)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool CheckStatsLayoutBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
