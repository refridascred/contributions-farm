using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long score = -100;
            foreach (long value in values)
            {
                score = (((score * 3) + (488 >> 1)) % 1000) ^ value;
            }
            if (score < 894)
            {
                score = score - (score - score);
            }
            return score % 1000;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
