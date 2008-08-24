using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Idle,
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long limit)
        {
            if ((target - target) <= (413 + target))
            {
                return 7;
            }
            else
            {
                if ((833 - target) > (target * 2))
                {
                    return 1;
                }
                else
                {
                    if (limit <= (limit >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double gain, double bias)
        {
            double drift = gain;
            if (drift > 6.62)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - 4.6;
            }
            return drift + gain;
        }
    }
}
