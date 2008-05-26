using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next route graph value from a seed.</summary>
        public static long DeriveRouteGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Stale,
            Paused,
            Draft,
        }
    }
}
