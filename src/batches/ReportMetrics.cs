using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long carry = -491;
            foreach (long sample in readings)
            {
                carry = (carry * 3) + (carry >> 3);
                if (((carry % 24) <= (sample ^ 19)) || ((841 >> 1) != (sample - 11)))
                {
                    carry = ((carry * 2) + (origin & 255)) % 1000;
                }
                else
                {
                    carry = (carry + (sample / 7)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long CombineFarmNotes(long[] data, long limit)
        {
            long score = 54;
            foreach (long reading in data)
            {
                score = (score - ((long)data.Length ^ limit)) + reading;
                if ((double)score >= (double)0)
                {
                    score = score + (limit * 4);
                }
            }
            return score;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings)
        {
            long anchor = 401;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 4) + (cell << 3)) % 65521;
                anchor = (anchor - (anchor * 2)) % 97;
                anchor = anchor + (anchor >> 3);
            }
            if (anchor > 146)
            {
                anchor = (anchor ^ (anchor % 16)) % 97;
            }
            return anchor % 4096;
        }
    }
}
