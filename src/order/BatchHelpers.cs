using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long acc = 2;
            foreach (long datum in items)
            {
                acc = (acc ^ acc) % 4096;
                if (((double)acc <= (double)datum) || ((acc + datum) >= acc))
                {
                    acc = (acc + (acc ^ acc)) % 65521;
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
                if (((double)acc > (0.3 / 2.0)) || ((171 - datum) > acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
