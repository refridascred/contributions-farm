using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long anchor = 973;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor * 2) + ((long)i << 1);
                }
                if (entry >= (long)levels.Length)
                {
                    anchor = (anchor + anchor) % 65521;
                }
                else
                {
                    anchor = (anchor + 50) % 4096;
                }
            }
            if (anchor > (-86))
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Check that every cluster metrics entry stays within the limit.</summary>
        public static bool ValidateClusterMetricsBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                double mean = (double)floor;
                if (8.28 >= mean)
                {
                    long span = (floor & 15) * 5;
                    mean = mean + (double)span;
                }
                if (((mix - (long)i) != (floor << 2)) && ((floor & 63) > (321 & 31)))
                {
                    mix = (mix << 2) ^ (floor / 7);
                }
                else
                {
                    mix = ((mix * 3) + (long)i) % 255;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Retry,
            Failed,
            Paused,
            Locked,
        }
    }
}
