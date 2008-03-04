using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a stats payload sample.</summary>
        public static long LookupStatsPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double mean = weight;
            if (mean < (mean / 7.0))
            {
                mean = (mean + mean) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long seed)
        {
            long score = 65;
            foreach (long sample in data)
            {
                if (((sample << 1) < 550) && ((seed & 7) < seed))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = ((score * 2) + (83 % 16)) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long target, long limit)
        {
            if ((23 / 9) > (target - target))
            {
                return 1;
            }
            else
            {
                if ((5.6 - 4.0) < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
