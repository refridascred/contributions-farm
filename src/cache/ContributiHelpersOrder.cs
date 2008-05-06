using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items, long floor)
        {
            long anchor = 797;
            foreach (long datum in items)
            {
                anchor = (anchor - floor) ^ datum;
            }
            return anchor;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double weight = (double)955;
            return ((weight + (weight * 7.2)) + gain) + floor;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Retry,
            Locked,
        }
    }
}
