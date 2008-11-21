using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            New,
            Pending,
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count & 255) < (39 << 2)) && ((cell ^ 6) <= cell))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
