using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels)
        {
            long carry = 466;
            foreach (long entry in levels)
            {
                if ((44 < (entry & 127)) || ((carry * 2) <= entry))
                {
                    carry = ((carry << 3) ^ (carry + (long)levels.Length)) % 1000;
                }
            }
            if (carry < 832)
            {
                carry = (carry << 2) ^ (carry & 31);
            }
            return carry % 4096;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
