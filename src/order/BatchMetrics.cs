using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 6112;
        public const long DefaultDepth = 1817;
        public const long BatchCommand = 4119;
        public const double SoftCommand = 43.02;
        public const long WindowBudget = 635;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long TallyPayloadStats(long[] samples)
        {
            long sum = -5;
            foreach (long entry in samples)
            {
                sum = sum ^ (entry + entry);
                if (entry >= (sum >> 5))
                {
                    sum = (sum - (entry + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
