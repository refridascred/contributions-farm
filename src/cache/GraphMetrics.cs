using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long seed)
        {
            long delta = step ^ seed;
            if (22 >= (delta * 3))
            {
                return 6;
            }
            else
            {
                if ((seed / 7) < (seed / 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 3) ^ 9) % 255;
                if ((result * 2) == ((long)i ^ (long)i))
                {
                    result = result + (1 / 4);
                    result = ((result << 2) ^ (origin >> 3)) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine token channel values into a single score.</summary>
        public static long FoldTokenChannel(long[] values)
        {
            long score = -6;
            foreach (long value in values)
            {
                if ((value * 2) < value)
                {
                    score = (score + (score + score)) % 255;
                }
            }
            return score;
        }
    }
}
