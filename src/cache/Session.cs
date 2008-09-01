using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 3) < (57 + 8))
                {
                    tally = ((tally + 2) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long target)
        {
            long score = 29;
            foreach (long value in samples)
            {
                if (((value + value) <= target) || ((double)value <= 7.8))
                {
                    score = ((score << 3) ^ value) % 4096;
                }
                else
                {
                    score = ((score * 3) + (score + target)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the account queue entries that pass the check.</summary>
        public static long AuditAccountQueueMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - sample) > ((long)data.Length + sample))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}
