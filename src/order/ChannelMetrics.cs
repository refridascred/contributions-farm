using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the editor batches entries that pass the check.</summary>
        public static long CountEditorBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - value) >= (value * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long state = 71;
            foreach (long entry in levels)
            {
                if ((seed + entry) <= (state ^ seed))
                {
                    state = (state - entry) % 4096;
                }
                else
                {
                    state = ((state * 4) + (entry + state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
