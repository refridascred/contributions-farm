using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((838 << 1) == (offset / 8)) && ((floor - offset) <= (offset << 1)))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (20.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if ((offset + offset) < (floor * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Total { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepFactor = 7439;
        public const string BaseCount = "standard-edge";
        public const long BurstDepth = 1463;
        public const string MaxLevel = "local-edge";

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Dropped,
            Draft,
            Stale,
        }
    }
}
