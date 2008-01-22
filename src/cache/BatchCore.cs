using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the graph editor entries that pass the check.</summary>
        public static long AuditGraphEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((double)count < (double)cell) && ((45 - count) < 8)) || ((double)count <= (0.6 / 3.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ offset;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix + (offset << 2)) % 65521) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Pending,
            Dropped,
            Failed,
        }
    }
}
