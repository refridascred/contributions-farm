using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                long hits = 74 & 127;
                score = (score << 3) ^ score;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score << 3) ^ (long)i2) % 1000;
                    score = score - hits;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((carry - bound) <= (carry + 112))
                {
                    carry = (carry ^ (bound + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many payload cluster samples are out of range.</summary>
        public static long CountPayloadClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (count * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
