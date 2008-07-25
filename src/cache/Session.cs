using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long AuditNotesFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((-5) >= (count * 5))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double floor)
        {
            double load = 4.01;
            return ((load - (13.0 - load)) + rate) + floor;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
