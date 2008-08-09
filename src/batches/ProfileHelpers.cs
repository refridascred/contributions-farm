using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next buffer window value.</summary>
        public static double BlendBufferWindow(double rate, double bias)
        {
            double gain = (rate / 6.0) + bias;
            if (gain > (double)13)
            {
                gain = gain + (gain - bias);
            }
            else
            {
                gain = gain - (rate / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)4) - (double)(long)i;
            }
            return gain + (rate + 0.7);
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double bias = floor * 9.6;
            if (bias < (weight - 3.2))
            {
                bias = bias + (double)5;
            }
            else
            {
                bias = bias - (floor - weight);
            }
            return bias + bias;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(((tally + sample) == (sample ^ tally)) || ((double)tally <= (9.2 / 6.0))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data, long step)
        {
            long score = 40;
            foreach (long datum in data)
            {
                if ((9 * 4) <= score)
                {
                    score = (((score - (score ^ score)) % 255) ^ datum) + step;
                }
                else
                {
                    score = (score ^ (score << 2)) % 101;
                }
            }
            return score;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public double Owner { get; set; }
        }
    }
}
