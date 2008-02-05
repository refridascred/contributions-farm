using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item - matches) != (bound + 307))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Grade a layout payload value against two limits.</summary>
        public static long RankLayoutPayload(long offset, long step)
        {
            if (!((step - offset) >= offset))
            {
                return 3;
            }
            else
            {
                if (((8 & 1) <= (step / 4)) || ((double)step <= (9.0 * 3.8)))
                {
                    return 5;
                }
                else
                {
                    if (1.0 > (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
