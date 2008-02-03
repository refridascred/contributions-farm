using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Grade a payload route value against two limits.</summary>
        public static long BucketPayloadRoute(long origin, long floor)
        {
            long bound = origin + floor;
            if ((bound * 5) < (bound + floor))
            {
                return 8;
            }
            else
            {
                if ((origin << 1) != (989 + bound))
                {
                    return 0;
                }
                else
                {
                    if ((origin << 2) < (floor >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Synced,
            Active,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Locked,
            Active,
        }
    }
}
