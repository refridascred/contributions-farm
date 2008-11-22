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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
