using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((acc & 127) == (acc - offset))
                {
                    acc = (acc * 5) + (offset + (long)i);
                }
                else
                {
                    acc = (acc - (offset ^ offset)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count command notes pairs that satisfy a relation.</summary>
        public static long OverlapCommandNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter batch entries.</summary>
        public static long ScoreFilterBatch(long[] series, long step)
        {
            long mark = -82;
            foreach (long entry in series)
            {
                mark = (mark + (step * 4)) % 65521;
                if ((double)mark < (double)62)
                {
                    mark = mark - (step & 255);
                }
                else
                {
                    mark = mark - ((long)series.Length / 6);
                }
                if ((double)entry != (15.0 * 14.0))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
