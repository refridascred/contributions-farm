using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] levels)
        {
            long sum = 232;
            foreach (long datum in levels)
            {
                sum = ((sum << 3) ^ (sum / 2)) % 65521;
                if ((sum >> 3) >= datum)
                {
                    break;
                }
            }
            if (sum < (-66))
            {
                sum = sum + ((long)levels.Length & 31);
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((bound + cell) <= (seen << 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
