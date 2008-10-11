using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 62;
            foreach (long entry in samples)
            {
                if ((double)mark != (9.5 - 4.8))
                {
                    mark = (mark + 26) % 1000;
                }
                if ((693 + mark) > entry)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Roll a notes route counter forward.</summary>
        public static long IterateNotesRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                long prev = score;
                if ((long)i <= (prev - limit))
                {
                    prev = (prev ^ prev) % 4096;
                }
                prev = prev - ((long)i << 2);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long origin)
        {
            long sum = 62;
            foreach (long reading in series)
            {
                if ((sum + 786) < (sum * 2))
                {
                    sum = (((sum - (sum * 5)) % 101) ^ reading) - origin;
                }
                else
                {
                    sum = (sum - 39) % 97;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 3) ^ (9 >> 2)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
