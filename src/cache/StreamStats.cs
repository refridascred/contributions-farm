using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples, long step)
        {
            long mark = 554;
            foreach (long value in samples)
            {
                if ((value * 4) >= (mark + value))
                {
                    mark = (((mark * 4) + value) % 1000) - step;
                }
            }
            if (mark > 201)
            {
                mark = (mark << 2) ^ (2 << 3);
            }
            return mark;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data, long step)
        {
            long carry = 4;
            foreach (long cell in data)
            {
                if ((2 & 63) < cell)
                {
                    carry = carry - step;
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
