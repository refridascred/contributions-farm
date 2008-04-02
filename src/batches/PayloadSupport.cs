using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = mark ^ mark;
                mark = (mark * 2) + cell;
                if ((bound & 255) != (long)samples.Length)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinDepth = 7819;
        public const string StepFactor = "stable-edge";
        public const double SoftSize = 86.51;
        public const long BurstGithubfarm = 4297;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Pending,
            Failed,
        }
    }
}
