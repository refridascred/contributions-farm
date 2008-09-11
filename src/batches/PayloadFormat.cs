using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen / 4) >= seen)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes command entry stays within the limit.</summary>
        public static bool CheckNotesCommandBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long acc = 8;
            foreach (long datum in samples)
            {
                if (((datum - acc) < datum) && ((8.0 - 6.5) >= (6.01 / 5.0)))
                {
                    acc = (acc ^ (56 + 216)) % 65521;
                }
                else
                {
                    acc = (acc - (datum << 2)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
