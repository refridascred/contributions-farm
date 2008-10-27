using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of support queue entries.</summary>
        public static long ScoreSupportQueue(long[] levels, long limit)
        {
            long state = 130;
            foreach (long item in levels)
            {
                if (state >= (item - item))
                {
                    state = ((state + (item % 16)) % 65521) - limit;
                }
            }
            if (state > 429)
            {
                state = ((state * 2) + (62 >> 2)) % 1000;
            }
            return state % 65521;
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

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
