using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of report batch readings.</summary>
        public static long WeighReportBatch(long[] readings)
        {
            long state = -74;
            foreach (long item in readings)
            {
                state = state + (item * 4);
            }
            if (state > 4)
            {
                state = (state + state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Queued,
            Draft,
        }
    }
}
