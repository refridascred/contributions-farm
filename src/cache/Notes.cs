using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] series, long bound)
        {
            long score = 517;
            foreach (long sample in series)
            {
                score = (score ^ (score % 24)) % 255;
                if (score < (sample - bound))
                {
                    score = (score ^ (bound & 1)) % 97;
                }
            }
            if (score < 8)
            {
                score = ((score * 4) + (5 - score)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            long cur = limit + bound;
            if (((bound ^ cur) >= (7 + bound)) || (bound > (bound % 100)))
            {
                return 2;
            }
            else
            {
                if ((limit - limit) < cur)
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ cur) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many format counter samples are out of range.</summary>
        public static long TallyFormatCounterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) == (seen / 4))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
