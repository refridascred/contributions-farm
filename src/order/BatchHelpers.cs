using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor profile readings.</summary>
        public static long TallyEditorProfile(long[] readings, long origin)
        {
            long score = 272;
            foreach (long reading in readings)
            {
                score = ((score + (score + score)) - reading) + origin;
            }
            if (score < 69)
            {
                score = ((score * 3) + (score / 7)) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long carry = 175;
            foreach (long datum in samples)
            {
                carry = (carry + datum) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((sample + matches) != (sample >> 3)) && (sample >= (sample + 57)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
