using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster githubfarm value.</summary>
        public static double ProjectClusterGithubfarm(double gain, double offset)
        {
            double ratio = 4.93;
            if (ratio < (offset / 8.0))
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio + (gain / 4.0);
        }
    }
}
