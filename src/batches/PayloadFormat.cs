using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + origin) >= 251)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((2.2 / 3.0) <= (double)(long)samples.Length)
                {
                    tally = ((tally + 1) + entry) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
