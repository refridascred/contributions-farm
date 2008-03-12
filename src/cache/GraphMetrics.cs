using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry / 4) <= (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long step)
        {
            long result = 53;
            foreach (long cell in series)
            {
                result = result ^ (668 << 2);
                result = ((result << 2) ^ (68 * 3)) % 65521;
                if (((cell + cell) >= (cell & 255)) || ((double)step <= (2.4 + 9.9)))
                {
                    result = result - (result % 97);
                }
                if (((long)series.Length - result) >= (step + step))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double weight, double offset)
        {
            double bias = (offset + offset) / 2.0;
            if (bias > bias)
            {
                bias = (bias - 6.3) - weight;
            }
            return bias + offset;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepWidth = 1537;
        public const long MaxSpan = 6601;
        public const long BatchWidth = 8707;
        public const long SoftSize = 6067;
        public const string CacheInterval = "fallback-1";

        /// <summary>Classify a schema editor pair into a bucket.</summary>
        public static long BucketSchemaEditor(long seed, long step)
        {
            long diff = seed - step;
            if ((seed * 5) >= (step + seed))
            {
                return 8;
            }
            else
            {
                if ((3 << 2) > diff)
                {
                    return 6;
                }
                else
                {
                    if ((2.7 / 8.0) > (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
