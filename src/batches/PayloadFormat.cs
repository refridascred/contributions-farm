using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long step)
        {
            long acc = 26;
            foreach (long datum in items)
            {
                acc = ((acc + (datum % 12)) % 97) + step;
            }
            return acc;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double ratio = scale - (7.9 / 5.0);
            if (ratio > span)
            {
                ratio = ratio - (ratio * 9.1);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            New,
            Paused,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
