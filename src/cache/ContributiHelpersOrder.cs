using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long step)
        {
            long anchor = 0;
            foreach (long item in data)
            {
                if ((step - item) < (item / 2))
                {
                    anchor = (anchor << 2) ^ ((-24) + step);
                }
                if (8.0 > (double)anchor)
                {
                    anchor = anchor ^ (398 + 221);
                }
                else
                {
                    anchor = (anchor * 2) + (step << 3);
                }
            }
            return anchor;
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
