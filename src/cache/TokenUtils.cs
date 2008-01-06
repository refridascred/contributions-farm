using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long target2)
        {
            long cur = target + target2;
            if ((-62) < cur)
            {
                return 8;
            }
            else
            {
                if ((cur << 2) >= target)
                {
                    return 3;
                }
                else
                {
                    if (((99 - cur) > (target + target2)) && ((target2 - cur) > cur))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
