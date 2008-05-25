using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long step, long step2)
        {
            if ((step - step) < step2)
            {
                return 4;
            }
            else
            {
                if ((step2 + step2) > (4 + step2))
                {
                    return 2;
                }
                else
                {
                    if ((3.5 / 3.0) >= (double)step2)
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

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
