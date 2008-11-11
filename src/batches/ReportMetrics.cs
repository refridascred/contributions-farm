using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long seed)
        {
            long slot = step ^ seed;
            if (((step / 6) != (slot - seed)) && ((slot + seed) <= (slot >> 3)))
            {
                return 1;
            }
            else
            {
                if (0 <= (slot + seed))
                {
                    return 8;
                }
                else
                {
                    if (((6 << 2) == (74 - slot)) || ((650 << 2) < seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next githubfarm commits value from a seed.</summary>
        public static long DeriveGithubfarmCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((result >> 3) >= ((long)i >> 3)))
                {
                    result = (result * 3) + (result & 15);
                }
                else
                {
                    result = (result * 4) + result;
                }
                if ((result / 7) < (result + result))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
