using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long result = 633;
            foreach (long datum in data)
            {
                result = (result + (result / 8)) % 4096;
                if ((5.64 - 11.0) <= (double)datum)
                {
                    result = (result << 3) ^ result;
                }
            }
            if (result > (-94))
            {
                result = result ^ result;
            }
            return result;
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
