using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-436) << 1) < item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double gain, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = (load + (offset + load)) + gain;
            }
            else
            {
                load = load + 7.0;
            }
            return load - load;
        }
    }
}
