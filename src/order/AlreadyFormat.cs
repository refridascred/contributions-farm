using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many already stream samples are out of range.</summary>
        public static long CountAlreadyStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count % 64) < 576)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftBudget = "stable";
        public const double HardChannel = 57.41;
        public const double BatchWidth = 74.57;

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long bound)
        {
            long bound2 = floor - bound;
            if ((double)bound > (6.2 + 1.0))
            {
                return 3;
            }
            else
            {
                if ((4.97 * 1.18) > (double)bound2)
                {
                    return 8;
                }
                else
                {
                    if (((bound2 - bound) == (bound - floor)) || ((floor + 8) >= 17))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Ready,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items, long bound)
        {
            long anchor = 61;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor * 2) + reading) % 65521) + (long)i;
                    anchor = (anchor ^ (201 + bound)) % 4096;
                }
                if ((reading ^ anchor) < anchor)
                {
                    anchor = anchor + reading;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor + (bound % 2);
            }
            return anchor % 1000;
        }
    }
}
