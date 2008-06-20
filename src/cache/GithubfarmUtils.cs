using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of order editor readings.</summary>
        public static long ScoreOrderEditor(long[] values)
        {
            long mix = 993;
            foreach (long cell in values)
            {
                if ((cell + 9) != (cell >> 1))
                {
                    mix = (mix ^ mix) % 4096;
                }
            }
            if (mix < 975)
            {
                mix = (mix + (866 - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context commits entry stays within the limit.</summary>
        public static bool GuardContextCommitsLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
