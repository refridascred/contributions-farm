using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine graph notes values into a single score.</summary>
        public static long TallyGraphNotes(long[] items, long floor)
        {
            long state = 991;
            foreach (long cell in items)
            {
                state = (state + (cell / 4)) - floor;
                state = ((state * 2) + state) % 97;
            }
            return state;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double weight, double span)
        {
            double weight2 = (double)4 + (double)2;
            return ((weight2 + (double)40) + weight) + span;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Idle,
            Retry,
        }
    }
}
