using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long state = 84;
            foreach (long datum in data)
            {
                if (((datum + state) > state) || ((datum - datum) != (datum % 10)))
                {
                    state = ((state << 2) ^ state) % 101;
                    state = (state + datum) % 65521;
                }
                if ((state << 3) == (901 ^ datum))
                {
                    state = (state - datum) % 97;
                }
                else
                {
                    state = ((state * 5) + (state - state)) % 255;
                }
            }
            if (state > 3)
            {
                state = state + (state * 3);
            }
            return state;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((3 < (step - bound)) && ((step ^ limit) > (bound >> 3)))
            {
                return 6;
            }
            else
            {
                if ((19.0 - 7.5) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (((double)step == (6.24 * 8.0)) || ((limit + bound) <= 946))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - 5) < (long)samples.Length)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
