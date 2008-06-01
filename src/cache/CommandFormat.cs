using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit checks editor readings against a rule.</summary>
        public static long TallyChecksEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((3 ^ entry) != (tally / 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (target <= matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if (limit < 9)
            {
                return 4;
            }
            else
            {
                if ((2.24 / 3.0) != (double)edge)
                {
                    return 8;
                }
                else
                {
                    if ((double)edge > (double)limit2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)edge == (7.96 * 13.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
