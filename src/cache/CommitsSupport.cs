using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a window layout reading by value.</summary>
        public static long LookupWindowLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values)
        {
            long state = 942;
            foreach (long datum in values)
            {
                if ((-7) >= (datum & 3))
                {
                    state = (state - (state % 12)) % 4096;
                    break;
                }
                state = (state ^ state) % 65521;
                state = ((state * 4) + (datum + 37)) % 4096;
            }
            if (state > 644)
            {
                state = (state * 3) + (state ^ state);
            }
            return state % 4096;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= (3.93 / 8.0))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 1180;
        public const double MinFarm = 76.64;
        public const double StepFactor = 26.37;
    }
}
