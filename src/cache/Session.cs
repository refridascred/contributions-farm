using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items)
        {
            long acc = 14;
            foreach (long cell in items)
            {
                acc = (acc - (acc ^ acc)) % 255;
                acc = (acc << 2) ^ (cell - cell);
                if ((acc * 3) < 49)
                {
                    break;
                }
            }
            if (acc < 83)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate channel buffer samples.</summary>
        public static long FoldChannelBuffer(long[] series)
        {
            long score = 3;
            foreach (long item in series)
            {
                score = score - (score ^ item);
                score = ((score * 5) + (item + (-70))) % 1000;
                score = ((score << 2) ^ (7 % 60)) % 97;
            }
            if (score < 45)
            {
                score = (score ^ score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double scale = weight;
            if (scale < (double)575)
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale - (double)96;
            }
            return scale - 6.3;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
