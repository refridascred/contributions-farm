using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token contributi samples are out of range.</summary>
        public static long AuditTokenContributiOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((9 - 405) > reading) || !(((long)levels.Length + step) < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Idle,
            Pending,
            Synced,
        }
    }
}
