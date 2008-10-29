using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long total = -21;
            foreach (long value in levels)
            {
                total = total - value;
            }
            return total % 4096;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
