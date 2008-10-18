using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum < (datum & 3)) && ((seen + 320) < step)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long acc = 660;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc - 0) % 255) ^ (long)i;
                }
                acc = acc ^ (datum / 5);
                if ((datum - datum) != (54 >> 1))
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = acc ^ (offset >> 1);
            }
            return acc;
        }
    }
}
