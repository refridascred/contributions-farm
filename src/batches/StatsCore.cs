using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Dropped,
            New,
            Closed,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long limit, long target)
        {
            long slot = limit - target;
            if ((slot % 7) != (7 + 5))
            {
                return 3;
            }
            else
            {
                if ((496 + target) >= (limit + 27))
                {
                    return 1;
                }
                else
                {
                    if (target <= (slot << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target >= (0 % 100)) || ((-85) >= (slot % 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9.0 / 8.0) < (double)seed)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Active,
            Closed,
            Idle,
            Queued,
        }
    }
}
