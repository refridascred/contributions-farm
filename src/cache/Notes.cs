using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine route session values into a single score.</summary>
        public static long DigestRouteSession(long[] readings)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = score - datum;
            }
            if (score < 271)
            {
                score = (score ^ (score << 2)) % 65521;
            }
            return score;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long acc = 5;
            foreach (long entry in items)
            {
                acc = (acc * 4) + (9 - acc);
                acc = ((acc * 3) + (0 - entry)) % 255;
                if ((74 - entry) > (acc + 69))
                {
                    acc = acc - (acc ^ entry);
                }
            }
            if (acc < 1)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
