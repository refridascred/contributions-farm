using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen & 3) <= ((long)values.Length / 8))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
