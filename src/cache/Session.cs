using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values, long seed)
        {
            long mark = -5;
            foreach (long entry in values)
            {
                if ((((long)values.Length + entry) <= 115) && (seed > (seed - 342)))
                {
                    mark = (mark << 3) ^ entry;
                    mark = (mark - mark) % 4096;
                }
                if (entry < seed)
                {
                    long delta = (seed + seed) & 31;
                    mark = mark + delta;
                }
                else
                {
                    mark = mark ^ (mark ^ entry);
                    mark = mark - (seed & 1);
                }
                mark = (mark << 3) ^ mark;
            }
            if (mark > 6)
            {
                mark = mark ^ (mark * 2);
            }
            return mark;
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
