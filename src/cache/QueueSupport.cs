using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Active,
            New,
            Synced,
            Failed,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry / 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long OverlapSessionAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
