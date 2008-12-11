using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((5.0 / 8.0) >= (8.0 - 6.9)) && ((double)seen >= (20.0 - 5.83))) || ((entry >> 2) <= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long step)
        {
            long edge = bound ^ step;
            if (((bound - 97) <= (edge >> 1)) && ((double)step <= (12.0 + 2.0)))
            {
                return 5;
            }
            else
            {
                if (((edge << 3) >= (edge & 63)) && (edge <= (step & 63)))
                {
                    return 6;
                }
                else
                {
                    if ((71 % 12) >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Active,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Iterate the schema githubfarm series from a seed.</summary>
        public static long StepSchemaGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = (score * 3) + (step + step);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
