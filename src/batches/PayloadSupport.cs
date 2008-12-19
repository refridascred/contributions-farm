using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series, long limit)
        {
            long mix = 67;
            foreach (long cell in series)
            {
                mix = ((mix ^ mix) - cell) - limit;
            }
            return mix;
        }
    }
}
