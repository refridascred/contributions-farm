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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
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
