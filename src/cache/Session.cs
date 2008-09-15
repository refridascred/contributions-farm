using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long seed)
        {
            long state = 1;
            foreach (long datum in series)
            {
                if ((double)state >= 8.0)
                {
                    state = (state ^ (datum >> 4)) - seed;
                }
            }
            return state;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count > (1.0 - 14.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
