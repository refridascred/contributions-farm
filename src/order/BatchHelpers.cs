using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                if ((9 & 31) >= acc)
                {
                    acc = (acc ^ (target & 7)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long score = 86;
            foreach (long reading in samples)
            {
                if ((score ^ score) > (reading % 97))
                {
                    score = (score ^ (score - reading)) % 97;
                }
                else
                {
                    score = (score * 5) + (501 + score);
                }
            }
            return score;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 10) != (matches - (-441)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
