using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a contributi record reading by value.</summary>
        public static long LookupContributiRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((3.55 + 6.53) >= (0.2 + 13.0))
                {
                    anchor = (anchor ^ anchor) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
