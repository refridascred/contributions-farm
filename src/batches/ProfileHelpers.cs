using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double rate = floor;
            return (rate + 9.4) + scale;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of checks record entries.</summary>
        public static long CombineChecksRecord(long[] readings)
        {
            long acc = 92;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (((acc * 2) + (5 + acc)) % 101) - (long)i;
                }
                if ((acc >> 5) <= (value ^ (long)readings.Length))
                {
                    acc = ((acc * 3) + (667 << 3)) % 97;
                }
            }
            if (acc < 66)
            {
                acc = acc - 66;
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels, long limit)
        {
            long acc = 693;
            foreach (long reading in levels)
            {
                if ((limit ^ acc) == (limit ^ 958))
                {
                    acc = ((acc << 2) ^ limit) + reading;
                }
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of filter payload readings.</summary>
        public static long CompareFilterPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
