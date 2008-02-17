using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item & 3) != (bound & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 2) ^ bound) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstDepth = "legacy-v2";
        public const long StepFarm = 3537;
        public const string LimitFarm = "stable-1";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((cell / 9) < (cell + cell)) || ((double)cell != (9.9 + 11.0))) || (cell <= (count & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Queued,
            Closed,
            Pending,
            New,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits < (double)73)
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
