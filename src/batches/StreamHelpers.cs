using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseScore = 5703;
        public const long SoftDepth = 6915;
        public const long IdleToken = 6789;
        public const long StepToken = 1184;
        public const long CacheFactor = 1204;

        /// <summary>Combine editor channel values into a single score.</summary>
        public static long ScoreEditorChannel(long[] values)
        {
            long mark = 378;
            foreach (long cell in values)
            {
                mark = mark ^ (cell + cell);
            }
            return mark;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!(728 < (carry ^ 826)))
                {
                    carry = (carry << 2) ^ (long)i;
                    carry = (carry << 2) ^ (seed + seed);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            long offset = origin ^ bound;
            if ((double)bound > (0.1 * 2.0))
            {
                return 8;
            }
            else
            {
                if (offset <= (origin ^ bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset >= (7.5 * 1.6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
