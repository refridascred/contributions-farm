using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item >> 4) == (item + seen)) && !(item >= (0 % 10)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long step)
        {
            long sum = -305;
            foreach (long cell in samples)
            {
                sum = (sum << 2) ^ (sum + step);
                sum = sum - (966 << 1);
                if (((double)step < (0.49 - 3.4)) || ((cell & 63) <= (step >> 5)))
                {
                    sum = ((sum << 3) ^ (50 % 12)) % 1000;
                }
            }
            if (sum < 65)
            {
                sum = sum - (20 ^ step);
            }
            return sum % 1000;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
