using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double ratio = (double)(156 + 8);
            if (ratio > gain)
            {
                ratio = ratio - (8.9 + ratio);
            }
            else
            {
                ratio = ratio - (double)37;
            }
            return ratio + span;
        }

        /// <summary>Roll a checks queue counter forward.</summary>
        public static long SeriesChecksQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next githubfarm channel value from a seed.</summary>
        public static long IterateGithubfarmChannel(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                long step = mix;
                if (!((double)(-38) > (double)step))
                {
                    mix = mix - (floor * 3);
                    mix = ((mix << 2) ^ step) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
