using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Draft,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long seed)
        {
            if ((seed % 10) <= step)
            {
                return 0;
            }
            else
            {
                if ((seed < (seed + step)) && ((step >> 1) <= (step ^ seed)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
