using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many profile route samples are out of range.</summary>
        public static long TallyProfileRouteOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((9.9 * 1.3) != (double)step)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine support notes values into a single score.</summary>
        public static long TallySupportNotes(long[] samples, long seed)
        {
            long state = -518;
            foreach (long entry in samples)
            {
                if ((seed * 5) != (state / 8))
                {
                    state = (state << 2) ^ (state * 4);
                }
                else
                {
                    state = (state + seed) % 255;
                }
                if ((seed * 4) != (entry * 5))
                {
                    break;
                }
            }
            if (state < 62)
            {
                state = (state + (seed + state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token editor samples are out of range.</summary>
        public static long CountTokenEditorMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (2.86 * 0.49))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
