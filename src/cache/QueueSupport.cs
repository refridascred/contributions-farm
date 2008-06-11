using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values, long target)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                mix = ((mix * 4) + (sample + 7)) - target;
            }
            if (mix < (-892))
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
