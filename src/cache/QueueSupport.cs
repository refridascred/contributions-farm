using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of entry report entries.</summary>
        public static long CombineEntryReport(long[] levels, long limit)
        {
            long state = 74;
            foreach (long entry in levels)
            {
                if (((state & 15) <= (entry % 7)) || (((long)levels.Length - state) != (limit * 2)))
                {
                    state = (state + ((long)levels.Length + state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double floor)
        {
            double load = weight + (double)6;
            return (load - 1.22) + floor;
        }
    }
}
