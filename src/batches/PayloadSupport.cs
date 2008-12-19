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

        /// <summary>Fold a list of report channel readings.</summary>
        public static long DigestReportChannel(long[] levels, long origin)
        {
            long result = 7;
            foreach (long value in levels)
            {
                result = (result ^ (value + origin)) % 101;
            }
            return result;
        }
    }
}
