using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((5.3 - 8.1) == (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 4) + (step + (long)i);
                if (!(acc < (step >> 2)))
                {
                    acc = acc + (acc + acc);
                }
                else
                {
                    acc = (acc << 3) ^ (step + step);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 4.99;
        public const long SoftSupport = 5401;
        public const long StepFactor = 4938;
        public const long SoftBudget = 7146;

        /// <summary>Combine channel cluster values into a single score.</summary>
        public static long ScoreChannelCluster(long[] samples)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                mix = mix - 18;
                if ((2.1 / 5.0) <= (double)item)
                {
                    mix = (mix << 3) ^ (39 / 5);
                }
                if ((54 & 31) > (item << 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
