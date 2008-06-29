using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of tools batches readings.</summary>
        public static long CompareToolsBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                if (((mark + 2) > (long)i) || ((target ^ target) < target))
                {
                    mark = (mark + (long)i) % 65521;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

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
