using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long origin, long step)
        {
            long slot = origin - step;
            if ((1.7 * 0.11) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (double)slot)
                {
                    return 2;
                }
                else
                {
                    if (((4.65 + 12.0) <= (double)step) && (origin >= (slot ^ origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + origin) > origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
