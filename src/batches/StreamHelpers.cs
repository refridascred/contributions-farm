using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next token command value from a seed.</summary>
        public static long StepTokenCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i << 1) >= 592)
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long limit2)
        {
            if (limit2 >= 358)
            {
                return 7;
            }
            else
            {
                if ((94 - limit) > (limit & 255))
                {
                    return 2;
                }
                else
                {
                    if ((limit2 << 1) < (43 - 643))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Ready,
            Active,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading / 7) < reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Level { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
