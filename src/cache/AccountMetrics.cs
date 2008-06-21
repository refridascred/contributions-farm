using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Done,
            Pending,
            Closed,
            New,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((step * 5) >= datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long TallyProfileSchemaHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count < 3.0)
                {
                    count = ((count + 2) - datum) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 1059;
        public const string MaxProfile = "strict-edge";
        public const string DefaultProfile = "alpha-edge";
    }
}
