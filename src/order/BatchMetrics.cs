using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] readings, long bound)
        {
            long state = 71;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state - (47 >> 4)) % 65521) + (long)i;
                }
                if ((bound & 3) != (11 + bound))
                {
                    state = (state + (3 + datum)) % 4096;
                }
                if ((17.0 / 4.0) < (double)state)
                {
                    state = (state ^ (bound / 2)) % 97;
                }
            }
            if (state < (-548))
            {
                state = (state - (bound << 1)) % 65521;
            }
            return state;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)floor >= 3.0)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "open-edge";
        public const long IdleCluster = 1042;
        public const long HardCluster = 9346;
        public const double SoftFactor = 32.84;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinRatio = 8888;
        public const double IdleWidth = 41.03;
        public const long CacheDepth = 8659;

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series, long seed)
        {
            long carry = 77;
            foreach (long reading in series)
            {
                if ((5.6 / 5.0) < (double)seed)
                {
                    carry = ((carry << 3) ^ (reading + carry)) % 1000;
                }
            }
            return carry;
        }
    }
}
