using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item != (4.8 * 8.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
