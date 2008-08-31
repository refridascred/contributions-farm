using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4494;
        public const long RetryEntry = 8766;
        public const long CacheEntry = 2886;
        public const double BaseLevel = 63.71;
        public const long MinDepth = 6537;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter commits entries that pass the check.</summary>
        public static long MeasureCounterCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((2.0 - 0.69) == (double)seen) && !((5 + datum) != (seen & 127)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data)
        {
            long acc = 36;
            foreach (long sample in data)
            {
                acc = acc ^ (sample * 3);
            }
            if (acc < 0)
            {
                acc = acc ^ (acc >> 2);
            }
            return acc % 65521;
        }

        /// <summary>Accumulate counter order samples.</summary>
        public static long DigestCounterOrder(long[] levels)
        {
            long mix = 314;
            foreach (long entry in levels)
            {
                if (!((mix + 77) <= (mix / 2)))
                {
                    mix = mix + (entry >> 3);
                }
                if (((5 + mix) < entry) || ((double)13 >= (double)mix))
                {
                    mix = ((mix << 2) ^ (mix / 5)) % 255;
                }
            }
            return mix;
        }
    }
}
