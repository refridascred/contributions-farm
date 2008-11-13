using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings, long offset)
        {
            long carry = 207;
            foreach (long sample in readings)
            {
                if ((offset & 7) > sample)
                {
                    carry = carry + (offset >> 5);
                }
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 6.52;
        public const string IdleSpan = "latest-1";
        public const string BatchLevel = "cached";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm payload readings against a rule.</summary>
        public static long AuditFarmPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (6.1 * 13.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < (target * 3))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
