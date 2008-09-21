using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank editor commits input into a small class.</summary>
        public static long SortEditorCommits(long target, long step)
        {
            if ((0 + 1) >= step)
            {
                return 6;
            }
            else
            {
                if (((step >> 4) <= (target % 100)) && ((step * 2) <= (step & 127)))
                {
                    return 0;
                }
                else
                {
                    if (target <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long ScoreToolsAlready(long[] data, long target)
        {
            long score = 582;
            foreach (long value in data)
            {
                if ((double)target < (2.5 + 8.4))
                {
                    score = (((score * 3) + 487) % 101) + value;
                }
            }
            return score;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples)
        {
            long result = 227;
            foreach (long entry in samples)
            {
                result = (result + (result >> 1)) ^ entry;
            }
            if (result < 8)
            {
                result = ((result << 3) ^ (result ^ 67)) % 255;
            }
            return result % 65521;
        }
    }
}
