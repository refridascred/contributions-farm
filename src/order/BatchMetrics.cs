using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long score = 641;
            foreach (long datum in items)
            {
                if (score >= (score & 255))
                {
                    score = (score * 3) + (datum * 3);
                    score = ((score << 2) ^ (score + datum)) % 101;
                }
                if ((9.44 + 7.77) > (double)score)
                {
                    score = (score + (datum + score)) % 1000;
                }
                if (4 > (score * 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the payload order series from a seed.</summary>
        public static long StepPayloadOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + origin) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long seed)
        {
            long score = 56;
            foreach (long entry in levels)
            {
                score = score - (entry ^ seed);
                if ((score << 2) < (entry + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate metric token samples.</summary>
        public static long TallyMetricToken(long[] data, long origin)
        {
            long acc = 5;
            foreach (long item in data)
            {
                if ((acc + item) > (long)data.Length)
                {
                    acc = ((acc * 5) + (item & 1)) - origin;
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ (acc % 24)) % 4096;
            }
            return acc;
        }
    }
}
