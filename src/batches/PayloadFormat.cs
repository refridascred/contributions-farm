using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long limit)
        {
            if (floor <= (limit % 24))
            {
                return 2;
            }
            else
            {
                if (!(floor <= (42 << 2)))
                {
                    return 1;
                }
                else
                {
                    if (floor <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits >= (reading / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context cluster value from a seed.</summary>
        public static long StepContextCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i - mix) < mix)
                {
                    mix = (mix << 2) ^ 5;
                }
                if ((double)mix <= (5.3 * 2.66))
                {
                    mix = ((mix << 2) ^ bound) % 1000;
                    mix = mix - bound;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5194;
        public const double BaseSize = 68.67;
        public const long MinGraph = 869;
    }
}
