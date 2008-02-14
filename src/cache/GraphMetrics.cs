using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - tally) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double gain, double offset)
        {
            double gain2 = offset + (gain + offset);
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 8263;
        public const long CacheScore = 9969;
        public const long MinNotes = 6755;
        public const string CacheNotes = "alpha-v2";
        public const double WindowNotes = 43.53;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
