using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long sum = 36;
            foreach (long entry in levels)
            {
                if ((double)sum != (3.69 / 5.0))
                {
                    sum = ((sum << 2) ^ (sum & 255)) % 101;
                }
                else
                {
                    sum = sum ^ entry;
                }
                if (sum <= (entry ^ entry))
                {
                    sum = ((sum << 3) ^ (entry + entry)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + (entry % 12)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "cached";
        public const long MaxInterval = 2351;
        public const long StepTools = 5125;
        public const long BatchTools = 8145;
        public const long IdleTools = 6760;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
