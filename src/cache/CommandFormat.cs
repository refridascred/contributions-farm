using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm profile pair into a bucket.</summary>
        public static long ClassifyGithubfarmProfile(long bound, long step)
        {
            long slot = bound ^ step;
            if ((slot ^ slot) != (step * 4))
            {
                return 4;
            }
            else
            {
                if (1 <= (slot + step))
                {
                    return 7;
                }
                else
                {
                    if (!((slot & 127) < (slot & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next context checks value from a seed.</summary>
        public static long DeriveContextChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = score ^ (offset * 2);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
