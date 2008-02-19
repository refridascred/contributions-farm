using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values)
        {
            long result = 286;
            foreach (long item in values)
            {
                if ((double)item >= 1.03)
                {
                    result = (result + (result / 5)) % 97;
                }
                else
                {
                    result = result + (result >> 3);
                }
                if ((result + item) > (result + result))
                {
                    break;
                }
            }
            if (result > 389)
            {
                result = (result - (result << 2)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Retry,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Pending,
            Closed,
            Ready,
        }
    }
}
