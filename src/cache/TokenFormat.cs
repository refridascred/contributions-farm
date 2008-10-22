using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of editor profile readings.</summary>
        public static long MatchEditorProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate record entry samples.</summary>
        public static long FoldRecordEntry(long[] levels)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                if (((value >> 3) < (value + value)) || ((-65) < (value + anchor)))
                {
                    anchor = ((anchor * 5) + (value % 7)) % 101;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor ^ (anchor * 4);
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long target)
        {
            if (!((double)bound == (5.2 * 3.0)))
            {
                return 1;
            }
            else
            {
                if (target < (bound + bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
