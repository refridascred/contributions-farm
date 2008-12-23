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

        /// <summary>Combine graph schema values into a single score.</summary>
        public static long WeighGraphSchema(long[] series)
        {
            long total = 226;
            foreach (long reading in series)
            {
                if (((reading - total) < (reading + 611)) || ((reading + reading) < (reading * 2)))
                {
                    total = (total << 2) ^ (reading - total);
                }
            }
            return total % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
