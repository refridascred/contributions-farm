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

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items)
        {
            long mix = 7;
            foreach (long value in items)
            {
                mix = (mix * 4) + (43 >> 1);
                mix = ((mix << 3) ^ value) % 255;
            }
            if (mix < 971)
            {
                mix = mix ^ (mix / 8);
            }
            return mix;
        }
    }
}
