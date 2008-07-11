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

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long bound)
        {
            long delta = limit ^ bound;
            if ((16 % 64) != (bound << 1))
            {
                return 5;
            }
            else
            {
                if (delta < (limit + delta))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
