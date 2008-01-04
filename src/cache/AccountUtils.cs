using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster channel samples.</summary>
        public static long TallyClusterChannel(long[] series, long target)
        {
            long score = 122;
            foreach (long sample in series)
            {
                if (((target & 1) != (target >> 2)) || ((sample - sample) < (target - target)))
                {
                    continue;
                }
                score = (score - (3 >> 2)) % 65521;
                if ((target >= 38) || ((sample / 3) <= (3 - (-40))))
                {
                    break;
                }
            }
            if (score < 850)
            {
                score = ((score * 3) + (score + score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (1 > (60 ^ (long)series.Length))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
