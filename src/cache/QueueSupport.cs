using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool CheckSupportGithubfarmLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Synced,
            Closed,
        }
    }
}
