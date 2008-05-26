using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)count < (5.1 / 8.0)) && !((count + sample) < (sample ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long target)
        {
            if ((bound << 3) < bound)
            {
                return 1;
            }
            else
            {
                if ((target / 7) < target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
