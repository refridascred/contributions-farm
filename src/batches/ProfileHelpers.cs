using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)floor > (double)mix)
                {
                    break;
                }
                long count = floor;
                if (!((floor << 3) < floor))
                {
                    mix = ((mix * 2) + count) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long target, long floor)
        {
            if (5.0 > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (8.0 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
