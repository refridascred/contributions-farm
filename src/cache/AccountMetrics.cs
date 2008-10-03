using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 1941;
        public const double RetryCache = 57.77;
        public const long IdleCache = 8796;
        public const long BatchCount = 8806;

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

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
