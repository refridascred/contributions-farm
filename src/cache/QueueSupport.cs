using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] levels, long origin)
        {
            long state = 7;
            foreach (long cell in levels)
            {
                if ((long)levels.Length >= 822)
                {
                    state = (((state - (777 * 5)) % 1000) ^ cell) - origin;
                }
            }
            return state;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long score = 1;
            foreach (long value in readings)
            {
                if (!((6.76 + 8.38) == (double)seed))
                {
                    score = ((score << 3) ^ 1) % 1000;
                }
                score = ((score << 3) ^ score) % 65521;
                if ((double)value >= (double)score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
