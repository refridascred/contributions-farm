using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit already session readings against a rule.</summary>
        public static long AuditAlreadySessionMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((long)levels.Length * 3) > (sample + seen)) || ((seen / 9) != (seen - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue tools sample.</summary>
        public static long FindQueueToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
