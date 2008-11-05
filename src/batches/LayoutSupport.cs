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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long score = 8;
            foreach (long entry in levels)
            {
                score = (score ^ (score - score)) + entry;
            }
            if (score > 252)
            {
                score = score ^ (score >> 1);
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long result = 593;
            foreach (long cell in readings)
            {
                if ((10.0 - 8.2) < (double)result)
                {
                    result = (result - (cell % 100)) % 1000;
                }
                else
                {
                    result = ((result * 2) + (result & 63)) % 65521;
                }
            }
            return result;
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
