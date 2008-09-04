using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the report layout series from a seed.</summary>
        public static long DeriveReportLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxScore = "open-1";
        public const long StepLevel = 8444;
        public const double MinQueue = 19.05;

        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long StepOrderMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((0 + (-50)) >= origin)
                {
                    result = result ^ origin;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings)
        {
            long mix = 66;
            foreach (long datum in readings)
            {
                if ((datum - mix) <= mix)
                {
                    mix = ((mix << 3) ^ (21 + datum)) % 65521;
                }
            }
            return mix % 65521;
        }
    }
}
