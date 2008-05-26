using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((4.2 * 7.37) > (double)entry) || ((entry / 8) <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long seed)
        {
            long bound = step - seed;
            if ((7.9 + 15.0) <= (double)step)
            {
                return 2;
            }
            else
            {
                if (step >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((step + bound) > (11 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
