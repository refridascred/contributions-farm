using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a window schema sample.</summary>
        public static long LocateWindowSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            New,
            Paused,
            Queued,
        }

        /// <summary>Digest a series of notes record entries.</summary>
        public static long TallyNotesRecord(long[] readings, long floor)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                result = (((result * 4) + (result + (-499))) + datum) + floor;
            }
            return result;
        }
    }
}
