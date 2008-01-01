using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double weight = bias;
            return (weight + (8.72 - 20.0)) + span;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = 357;
            foreach (long cell in levels)
            {
                sum = sum - cell;
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum - (cell + cell)) - (long)i;
                }
                if ((sum + cell) == (cell + sum))
                {
                    sum = sum ^ (cell & 31);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 15) >= (cell - cell))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
