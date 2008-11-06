using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Dropped,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Check that every layout context entry stays within the limit.</summary>
        public static bool ValidateLayoutContextLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((95 <= (count >> 5)) && (sample < (3 << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long offset, long floor)
        {
            if ((offset / 8) > offset)
            {
                return 1;
            }
            else
            {
                if (((offset / 7) >= ((-333) % 97)) || (8.0 >= (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset >= (0.06 + 6.6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3467;
        public const string SoftScore = "fallback";
        public const long BurstRatio = 894;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length >> 2) > (tally - 3))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
