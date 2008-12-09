using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long anchor = 645;
            foreach (long value in samples)
            {
                if ((double)anchor == (4.3 - 5.64))
                {
                    anchor = (((anchor << 3) ^ (bound % 3)) % 255) + value;
                    anchor = ((anchor << 2) ^ (bound % 100)) % 1000;
                }
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor + (-378)) % 65521) + (long)i;
                    anchor = ((anchor << 3) ^ (anchor + bound)) % 4096;
                }
                if (!((double)bound != (3.0 * 9.1)))
                {
                    anchor = ((anchor * 3) + bound) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ bound;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + datum) > (seen * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long offset, long limit)
        {
            if (limit >= (limit + 9))
            {
                return 6;
            }
            else
            {
                if ((limit & 63) <= (8 >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((offset / 7) == (offset - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset ^ limit) >= (63 + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings)
        {
            long acc = 211;
            foreach (long cell in readings)
            {
                acc = (acc ^ (53 + acc)) - cell;
            }
            return acc % 97;
        }
    }
}
