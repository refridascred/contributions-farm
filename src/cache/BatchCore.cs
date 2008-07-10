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

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long target)
        {
            long acc = 251;
            foreach (long reading in levels)
            {
                if ((reading >> 4) != (target + acc))
                {
                    acc = (acc - 686) % 65521;
                }
                else
                {
                    acc = (acc + acc) % 255;
                }
                if ((acc ^ acc) < acc)
                {
                    break;
                }
            }
            if (acc > 555)
            {
                acc = ((acc * 4) + target) % 97;
            }
            return acc;
        }

        /// <summary>Count the order metric entries that pass the check.</summary>
        public static long MeasureOrderMetricHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seed + seed) <= value)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
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
