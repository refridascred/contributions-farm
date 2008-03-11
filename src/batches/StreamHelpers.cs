using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Stale,
            Active,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long limit2)
        {
            long cur = limit + limit2;
            if ((578 + limit) <= (limit & 255))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (double)643)
                {
                    return 8;
                }
                else
                {
                    if ((cur + limit) >= (43 + limit2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a entry githubfarm pair into a bucket.</summary>
        public static long GradeEntryGithubfarm(long limit, long origin)
        {
            if (((limit - origin) >= limit) || (limit < (origin + origin)))
            {
                return 2;
            }
            else
            {
                if ((origin < (origin + origin)) && ((limit % 3) == (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin != (11.0 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0.09 - 3.8) >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((floor << 1) >= (seen / 7))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
