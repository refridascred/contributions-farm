using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double scale = (double)(589 % 16);
            if (scale < scale)
            {
                scale = (scale + gain) + bias;
            }
            else
            {
                scale = scale - (gain * 2.0);
            }
            return scale - (double)910;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits / 3) < (hits << 2))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long mix = -9;
            foreach (long datum in series)
            {
                if ((datum ^ mix) != ((long)series.Length + mix))
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                else
                {
                    mix = mix + (datum / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Project the next cache schema value.</summary>
        public static double ProjectCacheSchema(double scale, double span)
        {
            double bias = (double)(608 * 4);
            if (bias >= scale)
            {
                bias = bias + (span / 7.0);
            }
            return bias - span;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long floor)
        {
            long carry = -8;
            foreach (long sample in readings)
            {
                carry = ((carry << 2) ^ (floor + sample)) % 4096;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxTimeout = 5124;
        public const long MaxRecord = 5079;
        public const long MinInterval = 8344;
    }
}
