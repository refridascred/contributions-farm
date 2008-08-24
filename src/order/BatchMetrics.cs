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

        /// <summary>Adjust a schema support reading.</summary>
        public static double BlendSchemaSupport(double bias, double offset)
        {
            double drift = (5.2 / 7.0) * 6.8;
            if (drift >= drift)
            {
                drift = ((drift - (drift * 2.0)) - bias) + offset;
            }
            return drift + (double)619;
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
