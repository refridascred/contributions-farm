using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((20.0 / 7.0) > (double)sum))
                {
                    sum = (sum << 2) ^ ((long)i / 9);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches > (16.0 * 5.9))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long limit)
        {
            long score = 48;
            foreach (long sample in series)
            {
                if (99 >= (617 + sample))
                {
                    score = (score + limit) % 4096;
                }
            }
            return score;
        }
    }
}
