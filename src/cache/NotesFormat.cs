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

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 4305;
        public const long WindowToken = 6767;
        public const long BurstSize = 773;
        public const long DefaultToken = 889;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Ready,
            Closed,
        }
    }
}
