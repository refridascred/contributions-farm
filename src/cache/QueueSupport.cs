using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 5722;
        public const long BurstSupport = 893;
        public const long SoftSupport = 5146;
        public const long StepSupport = 3847;
        public const long WindowDepth = 5119;

        /// <summary>Fold a list of githubfarm report readings.</summary>
        public static long TotalGithubfarmReport(long[] readings)
        {
            long mark = 8;
            foreach (long cell in readings)
            {
                if (mark <= (217 >> 5))
                {
                    mark = (mark ^ cell) % 101;
                }
                else
                {
                    mark = mark ^ cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "stable-v2";
        public const long BaseFormat = 4921;
        public const string MinFormat = "alpha-1";
        public const long BatchFormat = 4263;
    }
}
