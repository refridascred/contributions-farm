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
