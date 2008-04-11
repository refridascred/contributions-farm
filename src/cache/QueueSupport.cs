using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate commits context samples.</summary>
        public static long TallyCommitsContext(long[] levels)
        {
            long state = -4;
            foreach (long entry in levels)
            {
                state = (state * 2) + (121 + state);
                if (((entry >> 5) < (entry >> 3)) && ((state - entry) > (state - (-41))))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
