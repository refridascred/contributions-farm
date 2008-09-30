using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of window layout readings.</summary>
        public static long MatchWindowLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
