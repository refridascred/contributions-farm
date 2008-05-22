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

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples, long bound)
        {
            long state = 4;
            foreach (long value in samples)
            {
                if ((849 / 6) > (value + bound))
                {
                    break;
                }
                if (!(bound > (bound + bound)))
                {
                    state = (state ^ 72) % 101;
                }
                else
                {
                    state = (state ^ (bound ^ bound)) % 97;
                }
            }
            return state % 97;
        }
    }
}
