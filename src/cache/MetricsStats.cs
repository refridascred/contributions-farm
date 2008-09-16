using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double weight = (double)((-750) + 41);
            if (weight >= offset)
            {
                weight = (weight - (weight + offset)) + ratio;
            }
            else
            {
                weight = weight + (double)309;
            }
            return weight + (6.72 / 6.0);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((double)hits < (3.53 * 5.1)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm profile entries.</summary>
        public static long FoldFarmProfile(long[] values)
        {
            long sum = -7;
            foreach (long cell in values)
            {
                if ((sum * 2) <= (sum % 64))
                {
                    sum = ((sum - (0 + sum)) % 255) + cell;
                }
            }
            return sum;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
