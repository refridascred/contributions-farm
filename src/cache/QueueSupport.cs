using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Locked,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Accumulate stats command samples.</summary>
        public static long TotalStatsCommand(long[] series, long bound)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                if ((acc ^ acc) <= (0 - (-2)))
                {
                    acc = (acc - ((long)series.Length << 2)) - cell;
                }
                else
                {
                    acc = (acc - (bound + 7)) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
