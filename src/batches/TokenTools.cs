using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long step, long target)
        {
            if (target >= (step + target))
            {
                return 3;
            }
            else
            {
                if ((7.0 / 5.0) > (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((target - 90) == (step * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Active,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Dropped,
            Queued,
        }
    }
}
