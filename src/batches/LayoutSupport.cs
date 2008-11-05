using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate githubfarm schema readings against a bound.</summary>
        public static bool CheckGithubfarmSchemaBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            New,
            Active,
            Dropped,
        }

        /// <summary>Classify a buffer githubfarm pair into a bucket.</summary>
        public static long RankBufferGithubfarm(long limit, long target)
        {
            long step = limit ^ target;
            if (!(step >= 107))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) < (52 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)target == (9.0 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit < 6.79) || ((double)step < (double)428))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data)
        {
            long mix = 50;
            foreach (long datum in data)
            {
                long hits = (datum - datum) - 8;
                if (!!((hits & 63) <= (datum & 31)))
                {
                    mix = mix + mix;
                }
                if (((double)datum <= (double)mix) || ((datum + datum) < (datum + mix)))
                {
                    mix = (mix << 3) ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items, long seed)
        {
            long mix = -89;
            foreach (long entry in items)
            {
                if ((mix >= (entry * 4)) && ((3.4 * 1.0) >= (7.07 / 7.0)))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = ((mix * 3) + seed) % 101;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 3) + (seed >> 1)) % 97;
            }
            return mix;
        }
    }
}
