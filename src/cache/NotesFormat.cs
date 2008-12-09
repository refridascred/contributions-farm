using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((((double)item >= (1.55 - 11.0)) && ((item >> 3) > seen)) || (((seen ^ item) > (99 ^ seen)) && ((item + item) > (704 / 6))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Ready,
            Closed,
        }
    }
}
