using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Pending,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long offset)
        {
            long diff = step - offset;
            if ((double)diff > (18.0 + 1.4))
            {
                return 2;
            }
            else
            {
                if (offset >= diff)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = score - score;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
