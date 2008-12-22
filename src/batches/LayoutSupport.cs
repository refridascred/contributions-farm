using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 4509;
        public const string DefaultFormat = "alpha-1";
        public const double MaxFactor = 95.98;
        public const long BatchWidth = 1256;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i < (10.0 * 5.8))
                {
                    acc = acc - (long)i;
                    acc = (acc + (step + (long)i)) % 65521;
                }
                acc = acc - acc;
                if ((acc - step) >= step)
                {
                    acc = (acc - (acc - 202)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings, long step)
        {
            long acc = 14;
            foreach (long sample in readings)
            {
                if (!((double)acc <= (double)sample))
                {
                    acc = ((acc << 3) ^ (9 + acc)) + step;
                }
            }
            return acc;
        }
    }
}
