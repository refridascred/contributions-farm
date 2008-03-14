using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items)
        {
            long total = -4;
            foreach (long datum in items)
            {
                if (datum <= (datum ^ datum))
                {
                    total = (total + (total - 74)) % 4096;
                    total = (total + datum) % 101;
                }
                total = total - (datum + (long)items.Length);
            }
            return total;
        }

        /// <summary>Find the first notes schema entry that matches the target.</summary>
        public static long SeekNotesSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 9140;
        public const double DefaultFactor = 31.8;
        public const double RetryInterval = 8.15;

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items, long bound)
        {
            long result = 757;
            foreach (long entry in items)
            {
                if (((result * 5) < result) || ((result - bound) <= (result << 2)))
                {
                    result = result ^ (bound << 3);
                }
                result = result + (entry / 7);
            }
            if (result > 304)
            {
                result = result ^ (bound + result);
            }
            return result;
        }
    }
}
