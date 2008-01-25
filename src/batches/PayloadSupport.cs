using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Locked,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long target)
        {
            if (target > 66)
            {
                return 7;
            }
            else
            {
                if (577 <= (target + limit))
                {
                    return 4;
                }
                else
                {
                    if ((7.4 - 4.3) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 4) > target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Paused,
            Failed,
            Draft,
            Active,
        }
    }
}
