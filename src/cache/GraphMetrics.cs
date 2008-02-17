using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long step)
        {
            if (((step / 8) != (step >> 5)) && ((0.48 * 0.8) > (double)step))
            {
                return 7;
            }
            else
            {
                if (((15.0 / 4.0) != (double)floor) && ((step >> 5) != (step + floor)))
                {
                    return 2;
                }
                else
                {
                    if ((32 + floor) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the account checks series from a seed.</summary>
        public static long StepAccountChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if (bound <= 97)
                {
                    state = ((state * 4) + (long)i) % 4096;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (state - (state << 3)) + (long)i2;
                }
                state = (state << 3) ^ (state * 3);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 8) <= (datum << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
