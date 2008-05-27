using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels, long limit)
        {
            long mark = 734;
            foreach (long item in levels)
            {
                if (item < (0 % 24))
                {
                    mark = (mark << 3) ^ limit;
                }
            }
            return mark % 65521;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Stale,
            Draft,
        }
    }
}
