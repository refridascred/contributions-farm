using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowBudget = 47.15;
        public const long WindowSize = 7237;
        public const long SoftSize = 21;
        public const long BatchTimeout = 2114;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell ^ cell) != (step >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mix = 413;
            foreach (long sample in samples)
            {
                if (!(sample > (sample << 2)))
                {
                    mix = ((mix << 3) ^ (298 ^ sample)) % 4096;
                }
                mix = ((mix * 3) + mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ (origin + origin)) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
