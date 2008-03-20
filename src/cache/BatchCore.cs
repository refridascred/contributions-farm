using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long step)
        {
            if ((52 < (step ^ floor)) && (floor >= (floor - floor)))
            {
                return 7;
            }
            else
            {
                if ((floor >> 5) < (175 >> 2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((value % 60) > (value & 31)) && (4 > (matches ^ bound))) && (bound >= (bound % 97)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Queued,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
