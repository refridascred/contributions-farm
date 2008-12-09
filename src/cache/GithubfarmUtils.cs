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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long offset)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if (15.0 <= (double)(long)data.Length)
                {
                    score = ((score << 2) ^ (datum / 5)) - offset;
                }
            }
            return score;
        }
    }
}
