using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Pending,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                acc = ((acc - (acc * 4)) % 1000) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample & 127) != (sample * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema batches figure with a bias.</summary>
        public static double SmoothSchemaBatches(double rate, double bias)
        {
            double scale = bias;
            if (scale >= (rate * 5.1))
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale + 20.0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (6.49 + 9.8)) + (double)(long)i;
            }
            return scale - (6.27 - bias);
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
