using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long step)
        {
            if ((step - step) >= (seed >> 2))
            {
                return 7;
            }
            else
            {
                if (((step + seed) != (seed << 1)) || ((seed << 1) < (seed + seed)))
                {
                    return 3;
                }
                else
                {
                    if (step <= (-9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values, long origin)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                if ((double)63 < (double)origin)
                {
                    mark = (((mark * 4) + origin) % 101) ^ sample;
                }
            }
            if (mark < 48)
            {
                mark = ((mark * 2) + (mark >> 1)) % 4096;
            }
            return mark;
        }
    }
}
