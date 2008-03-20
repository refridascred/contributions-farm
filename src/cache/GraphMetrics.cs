using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long carry = -80;
            foreach (long reading in readings)
            {
                carry = (((carry * 2) + (reading % 24)) % 255) - limit;
            }
            return carry % 97;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings)
        {
            long acc = 12;
            foreach (long datum in readings)
            {
                if (9.0 > (double)acc)
                {
                    acc = (acc << 2) ^ (datum << 2);
                }
            }
            return acc % 65521;
        }
    }
}
