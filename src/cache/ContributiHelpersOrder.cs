using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + 260;
                if (((long)i * 5) <= (floor + floor))
                {
                    mark = mark + 982;
                }
                mark = (mark + 8) % 255;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
