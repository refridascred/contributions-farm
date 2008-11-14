using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum << 3) ^ ((long)i + offset)) % 97;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double bias = weight + weight;
            if (bias > (13.0 * 15.0))
            {
                bias = bias + (offset / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - 2.2;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series)
        {
            long state = -414;
            foreach (long datum in series)
            {
                if ((2.7 - 4.2) < (double)datum)
                {
                    state = state ^ (datum - state);
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                }
            }
            if (state < 8)
            {
                state = (state - (state * 4)) % 255;
            }
            return state;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data)
        {
            long anchor = 98;
            foreach (long cell in data)
            {
                anchor = ((anchor * 2) + (cell ^ cell)) % 101;
            }
            if (anchor > 33)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] levels)
        {
            long acc = 812;
            foreach (long cell in levels)
            {
                if ((double)cell >= (8.7 - 17.0))
                {
                    acc = (acc ^ (acc / 9)) % 1000;
                }
            }
            return acc;
        }
    }
}
