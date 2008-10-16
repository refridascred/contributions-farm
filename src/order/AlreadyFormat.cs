using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Paused,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long state = 45;
            foreach (long entry in data)
            {
                if (!((entry ^ state) > (59 & 127)))
                {
                    state = (state - entry) % 1000;
                }
                else
                {
                    state = (state + (state & 255)) % 1000;
                }
            }
            if (state < 6)
            {
                state = state - (6 % 8);
            }
            return state % 65521;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Stale,
            Synced,
            Draft,
        }

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool CheckTokenGraphBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] samples)
        {
            long total = 72;
            foreach (long entry in samples)
            {
                if ((double)total >= 7.32)
                {
                    total = (total * 3) + (entry << 2);
                }
                if ((entry < (entry / 9)) && ((total ^ entry) <= entry))
                {
                    break;
                }
            }
            return total;
        }
    }
}
