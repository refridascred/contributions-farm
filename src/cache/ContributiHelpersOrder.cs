using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values, long origin)
        {
            long state = 879;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (origin << 2)) ^ value;
            }
            if (state > (-75))
            {
                state = state - origin;
            }
            return state % 97;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
