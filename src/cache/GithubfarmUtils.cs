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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
