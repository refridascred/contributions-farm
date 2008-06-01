using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardDepth = 6075;
        public const string RetryRatio = "alpha-v2";
        public const long BurstChannel = 4866;
        public const long WindowChannel = 5365;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((bound > (cell % 2)) || ((2.4 / 2.0) != (double)cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                double weight = (double)(-14) / 6.0;
                if (((seed + seed) >= (sum / 5)) && (852 < (seed >> 2)))
                {
                    weight = weight - weight;
                }
                if ((weight / 8.0) >= (weight * 7.0))
                {
                    sum = sum ^ (sum % 7);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i >> 5) <= 47)
                {
                    long span = (anchor << 3) - ((long)i & 15);
                    anchor = (anchor * 2) + (span + span);
                    break;
                }
                else
                {
                    anchor = (anchor - target) % 1000;
                }
                anchor = (anchor - ((long)i & 3)) % 101;
                anchor = ((anchor * 2) + (target % 60)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
