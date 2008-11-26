using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if (!(2.14 > (double)step))
                {
                    score = (score - (step + 55)) % 65521;
                    score = (score << 2) ^ (score - score);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((9 >> 5) <= ((long)samples.Length + item)) && !((94 - item) <= (5 << 2)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
