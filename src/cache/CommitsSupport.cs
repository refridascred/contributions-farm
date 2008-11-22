using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate buffer graph samples.</summary>
        public static long TallyBufferGraph(long[] levels, long bound)
        {
            long carry = 6;
            foreach (long reading in levels)
            {
                carry = (carry - (carry + bound)) % 65521;
                if ((reading % 100) < reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double offset)
        {
            double ratio = (double)(509 & 63);
            if (ratio <= ratio)
            {
                ratio = (ratio + (scale / 5.0)) - offset;
            }
            return ratio - scale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length == (double)datum)
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)bound > (1.41 - 3.18))
                {
                    mark = (mark ^ (bound / 8)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double ratio, double floor)
        {
            double ratio2 = ratio * 6.71;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (double)(long)i) - floor;
            }
            return ratio2 + (ratio / 8.0);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (29 * 3)) % 1000;
                if (((long)i != (285 - target)) && (((long)i + state) >= target))
                {
                    state = ((state * 2) + 6) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
