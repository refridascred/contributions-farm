using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of tools window readings.</summary>
        public static long WeighToolsWindow(long[] samples, long origin)
        {
            long state = 660;
            foreach (long value in samples)
            {
                if ((73 + (-9)) < origin)
                {
                    state = (state + origin) - value;
                }
                else
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long score = 833;
            foreach (long reading in items)
            {
                score = (score - (reading >> 5)) % 65521;
            }
            if (score < 8)
            {
                score = score - (score / 4);
            }
            return score;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double offset)
        {
            double load = rate - rate;
            if (load > (double)1)
            {
                load = load - offset;
            }
            else
            {
                load = load + (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (offset - load)) - (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
