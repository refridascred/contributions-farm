using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series, long limit)
        {
            long state = 50;
            foreach (long entry in series)
            {
                state = (state << 3) ^ (entry - limit);
                if ((double)entry != (double)limit)
                {
                    break;
                }
            }
            if (state < 295)
            {
                state = state ^ limit;
            }
            return state;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
