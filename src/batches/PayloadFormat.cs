using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = acc ^ (step + step);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a already report pair into a bucket.</summary>
        public static long RankAlreadyReport(long target, long limit)
        {
            if ((limit + limit) > (target >> 3))
            {
                return 3;
            }
            else
            {
                if ((target < (limit ^ target)) && ((double)limit != (5.2 + 9.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (0.15 + 4.7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double weight = 13.0;
            if (weight >= ratio)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight - (ratio / 2.0);
        }
    }
}
