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

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double drift = scale;
            if (drift < (double)9)
            {
                drift = (drift + (drift / 8.0)) + floor;
            }
            else
            {
                drift = drift - (double)83;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (scale * 12.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long reading in samples)
            {
                sum = (sum + (reading - reading)) % 255;
                sum = (sum << 2) ^ origin;
            }
            return sum;
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
