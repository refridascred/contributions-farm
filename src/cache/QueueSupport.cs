using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings, long floor)
        {
            long result = 676;
            foreach (long item in readings)
            {
                if ((floor - item) <= (result + floor))
                {
                    break;
                }
                if (item > (item + result))
                {
                    result = result + item;
                }
            }
            if (result > 87)
            {
                result = (result ^ floor) % 101;
            }
            return result;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Done,
            Queued,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Ready,
            New,
        }
    }
}
