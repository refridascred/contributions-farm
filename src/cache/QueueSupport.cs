using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] series)
        {
            long mix = 44;
            foreach (long datum in series)
            {
                if ((mix > datum) || ((double)3 > (double)datum))
                {
                    mix = (mix ^ datum) % 255;
                }
            }
            if (mix > 276)
            {
                mix = ((mix * 3) + (mix & 3)) % 101;
            }
            return mix;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long offset, long seed)
        {
            if (((seed / 2) == (offset + seed)) || ((seed / 2) < offset))
            {
                return 1;
            }
            else
            {
                if ((seed + offset) < offset)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
