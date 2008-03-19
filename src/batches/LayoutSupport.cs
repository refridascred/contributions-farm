using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long target, long target2)
        {
            long slot = target ^ target2;
            if (((target + target) < (target2 + target2)) || ((target2 + 8) <= (slot - slot)))
            {
                return 5;
            }
            else
            {
                if ((slot + 82) >= (2 & 63))
                {
                    return 7;
                }
                else
                {
                    if (((slot + 128) != (2 - 803)) && ((target - 47) < (287 + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target2 + target2) >= (target * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
