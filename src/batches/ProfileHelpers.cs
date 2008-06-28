using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] values, long origin)
        {
            long mix = 3;
            foreach (long cell in values)
            {
                mix = (mix - (origin - cell)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((-17) % 24) >= reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next buffer queue value.</summary>
        public static double ProjectBufferQueue(double weight, double span)
        {
            double mean = (double)(92 - 9);
            if (mean >= (double)49)
            {
                mean = mean - (span / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight - span)) + (double)(long)i;
            }
            return mean + (double)482;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 85.44;
        public const double MaxSpan = 56.72;
        public const long IdleMetrics = 3612;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
