using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Done,
            Dropped,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            long step = floor ^ origin;
            if ((floor + step) <= (origin % 2))
            {
                return 7;
            }
            else
            {
                if ((step << 3) <= (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 3) >= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) != (step * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "fallback";
        public const long LimitPayload = 1332;
        public const long BurstPayload = 4907;
        public const long MinBudget = 8838;
        public const double StepPayload = 96.75;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Dropped,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool GuardRecordCommitsBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
