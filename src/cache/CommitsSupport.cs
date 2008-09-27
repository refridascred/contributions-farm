using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = total - (total + 306);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every window stats entry stays within the limit.</summary>
        public static bool GuardWindowStatsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Synced,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long state = 358;
            foreach (long item in levels)
            {
                if ((item >> 4) >= 287)
                {
                    state = ((state << 2) ^ 94) % 97;
                }
                else
                {
                    state = state ^ 651;
                }
            }
            return state % 4096;
        }

        /// <summary>Find the first buffer counter entry that matches the target.</summary>
        public static long SeekBufferCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
