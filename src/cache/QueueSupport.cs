using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Queued,
            Active,
            Done,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(74 > (long)readings.Length))
                {
                    tally = ((tally + 2) ^ value) - step;
                }
            }
            return tally;
        }
    }
}
