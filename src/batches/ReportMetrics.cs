using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long step)
        {
            if ((double)bound > (5.7 * 9.0))
            {
                return 1;
            }
            else
            {
                if (step >= (bound % 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (19.0 * 2.69))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            New,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long acc = 8;
            foreach (long item in samples)
            {
                acc = (acc * 3) + (item & 63);
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 65521;
        }
    }
}
