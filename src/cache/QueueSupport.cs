using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank route record input into a small class.</summary>
        public static long RankRouteRecord(long limit, long step)
        {
            if ((double)step > 1.3)
            {
                return 4;
            }
            else
            {
                if ((double)limit <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((limit / 6) <= (step & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowInterval = "open";
        public const double DefaultAccount = 18.04;
        public const long MinAccount = 7541;
        public const long HardAccount = 7445;
        public const double BaseFactor = 53.94;
    }
}
