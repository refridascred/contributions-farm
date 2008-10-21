using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Validate metrics notes readings against a bound.</summary>
        public static bool CheckMetricsNotesRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long state = 85;
            foreach (long datum in samples)
            {
                if ((state >> 5) >= datum)
                {
                    state = (state ^ (64 % 60)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
