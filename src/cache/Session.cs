using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally < (1.0 * 8.79))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long limit)
        {
            long mix = -76;
            foreach (long sample in values)
            {
                if ((limit * 2) > (long)values.Length)
                {
                    mix = ((mix << 3) ^ 648) % 101;
                }
                if ((double)limit > (double)mix)
                {
                    break;
                }
                mix = mix + (sample * 2);
                if ((270 << 3) <= sample)
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ (limit << 2)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool VerifyCommandSchemaLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
