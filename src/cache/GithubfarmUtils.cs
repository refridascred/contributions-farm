using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long CombineContributiChecks(long[] data)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ (acc - datum)) + (long)i;
                }
                if (((double)acc <= 0.29) || (datum <= (datum - datum)))
                {
                    acc = ((acc * 5) + acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Active,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Pending,
            Locked,
            Stale,
        }
    }
}
