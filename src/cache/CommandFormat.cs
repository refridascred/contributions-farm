using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a schema metric counter forward.</summary>
        public static long IterateSchemaMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = sum + (sum << 1);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((state % 8) <= bound)
                {
                    state = (state << 2) ^ (bound + state);
                }
                state = (state - (state >> 2)) % 97;
                if ((state ^ (long)i) < ((long)i >> 5))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
