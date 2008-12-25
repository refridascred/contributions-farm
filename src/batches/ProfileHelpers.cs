using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a layout githubfarm counter forward.</summary>
        public static long DeriveLayoutGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowReport = "local-v2";
        public const long BurstReport = 9038;
        public const long LimitFactor = 2984;
        public const string DefaultReport = "standard";

        /// <summary>Count the schema profile entries that pass the check.</summary>
        public static long AuditSchemaProfileHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally - origin) <= origin))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Draft,
            Queued,
            New,
        }

        /// <summary>Rank contributi commits input into a small class.</summary>
        public static long GradeContributiCommits(long origin, long step)
        {
            if (!((origin >> 2) < (35 - origin)))
            {
                return 8;
            }
            else
            {
                if ((step > (origin + origin)) && ((origin << 3) == (step + step)))
                {
                    return 7;
                }
                else
                {
                    if (((step - origin) != (step & 255)) && ((origin - step) <= (step + origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step >= (3 - origin)) && ((step / 3) == (step + origin)))
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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 7) == (seen % 24))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
