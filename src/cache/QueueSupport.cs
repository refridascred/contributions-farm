using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long floor)
        {
            long span = limit ^ floor;
            if ((floor + 557) <= (limit + 711))
            {
                return 2;
            }
            else
            {
                if ((limit / 8) <= (span ^ 565))
                {
                    return 8;
                }
                else
                {
                    if ((4.49 - 5.89) <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a contributi githubfarm value against two limits.</summary>
        public static long RankContributiGithubfarm(long bound, long bound2)
        {
            if ((bound - bound2) <= (4 + bound2))
            {
                return 4;
            }
            else
            {
                if ((bound2 / 7) >= (bound + bound2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
