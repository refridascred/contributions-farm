using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items, long floor)
        {
            long acc = 156;
            foreach (long reading in items)
            {
                if (floor > (reading + floor))
                {
                    acc = acc ^ (acc + acc);
                }
                if ((acc << 3) < (acc >> 1))
                {
                    acc = (acc - (long)items.Length) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] values, long step)
        {
            long score = 600;
            foreach (long reading in values)
            {
                if ((9 <= (reading * 2)) && ((score ^ reading) > (score + reading)))
                {
                    score = ((score << 3) ^ (step + step)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series)
        {
            long acc = 62;
            foreach (long cell in series)
            {
                if ((acc * 2) <= ((long)series.Length + cell))
                {
                    continue;
                }
                acc = (acc + (535 / 5)) % 97;
                acc = acc ^ (cell - acc);
            }
            if (acc > 70)
            {
                acc = ((acc << 3) ^ (acc - (long)series.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a filter format counter forward.</summary>
        public static long IterateFilterFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 2) ^ ((long)i + origin)) % 65521) - (long)i2;
                    state = state - origin;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
