using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long offset)
        {
            long bound = floor + offset;
            if (((floor + bound) > (bound % 60)) || (offset < (floor + offset)))
            {
                return 6;
            }
            else
            {
                if (58 <= (bound + offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= (16.0 / 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((4.0 / 9.0) >= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
