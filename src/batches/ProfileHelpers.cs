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

        /// <summary>Classify a contributi stream pair into a bucket.</summary>
        public static long BucketContributiStream(long target, long offset)
        {
            if ((815 << 2) > (offset + target))
            {
                return 7;
            }
            else
            {
                if ((9.47 / 8.0) == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((double)(-1) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset >= 4) || ((target + offset) > (target + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
