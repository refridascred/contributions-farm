using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i < 4.0)
                {
                    sum = (sum << 3) ^ (sum + origin);
                    sum = sum - origin;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
