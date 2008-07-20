using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of graph command readings.</summary>
        public static long DigestGraphCommand(long[] values, long target)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = (((mark * 5) + (mark % 24)) % 255) + entry;
            }
            if (mark < 5)
            {
                mark = (mark << 2) ^ (target + target);
            }
            return mark;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
