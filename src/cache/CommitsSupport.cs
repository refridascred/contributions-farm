using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long state = 90;
            foreach (long item in samples)
            {
                if (((item * 2) <= (item >> 1)) && ((state & 255) == (360 << 1)))
                {
                    state = (state + (state & 31)) % 255;
                }
            }
            if (state > 1)
            {
                state = state + state;
            }
            return state % 65521;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double offset)
        {
            double bias = 8.0;
            if (bias < offset)
            {
                bias = (bias - offset) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - 8.4) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Compare every pair of graph token readings.</summary>
        public static long MatchGraphTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((floor - floor) == (long)i) || (total <= (floor - 34)))
                {
                    total = (total * 2) + (8 - floor);
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                if (!((6.13 - 2.88) < (double)(long)i))
                {
                    total = (total - (5 >> 5)) % 4096;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] levels)
        {
            long mark = 722;
            foreach (long item in levels)
            {
                if ((mark + item) < mark)
                {
                    mark = (mark << 2) ^ (mark + item);
                }
            }
            return mark % 97;
        }
    }
}
