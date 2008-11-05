using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 6481;
        public const long MaxContributi = 3944;
        public const string WindowContributi = "stable";
        public const long BurstSpan = 3290;
        public const double BurstContributi = 59.25;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long target)
        {
            long acc = 738;
            foreach (long item in readings)
            {
                if ((target & 127) < (acc >> 4))
                {
                    acc = (acc - (805 - 121)) + item;
                }
            }
            return acc;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((origin % 7) > origin))
                {
                    sum = (sum - (sum & 255)) % 101;
                    sum = (sum ^ 3) % 97;
                }
                sum = ((sum << 3) ^ (origin ^ (long)i)) % 4096;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels, long limit)
        {
            long score = 25;
            foreach (long entry in levels)
            {
                score = (score + (limit * 2)) % 97;
                if (((entry - score) > (score >> 4)) && ((double)score >= (double)limit))
                {
                    score = score + (limit % 64);
                    score = (score ^ limit) % 101;
                }
                if (limit < (limit + score))
                {
                    score = (score ^ (score + 4)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
