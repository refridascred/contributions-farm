using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 8836;
        public const long BatchCache = 9413;
        public const string RetryBudget = "cached-edge";
        public const double BaseScore = 24.32;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 3) ^ (long)i) % 255;
                if ((result > ((long)i << 2)) || (target < (result - target)))
                {
                    result = (result + (long)i) % 255;
                    result = (result + ((long)i >> 3)) % 1000;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 0;
            foreach (long datum in series)
            {
                if (((mix ^ datum) <= (93 & 15)) && ((datum + datum) < (datum - mix)))
                {
                    mix = (mix * 2) + (694 / 2);
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (72 / 7)) % 4096;
            }
            return mix;
        }

        /// <summary>Match up channel window samples.</summary>
        public static long OverlapChannelWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Retry,
            New,
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long CountMetricProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((6.3 + 13.0) >= (double)step) && ((matches - value) > (value / 6))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
