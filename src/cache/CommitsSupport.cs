using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine channel profile values into a single score.</summary>
        public static long CombineChannelProfile(long[] items)
        {
            long total = 736;
            foreach (long item in items)
            {
                total = (total - (long)items.Length) ^ item;
            }
            if (total < 3)
            {
                total = (total * 5) + (total + total);
            }
            return total % 4096;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples, long offset)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if ((double)offset < 7.3)
                {
                    mix = (mix ^ mix) ^ sample;
                }
            }
            if (mix > 88)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] levels, long step)
        {
            long sum = 3;
            foreach (long reading in levels)
            {
                if ((reading & 31) >= ((long)levels.Length - (long)levels.Length))
                {
                    sum = ((sum ^ (41 << 2)) % 65521) + step;
                }
            }
            if (sum > 14)
            {
                sum = (sum * 4) + (81 ^ sum);
            }
            return sum;
        }

        /// <summary>Combine metric checks values into a single score.</summary>
        public static long CombineMetricChecks(long[] samples)
        {
            long result = 3;
            foreach (long value in samples)
            {
                if ((248 + value) == (value * 4))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                if (result <= 8)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of stats profile readings.</summary>
        public static long ScoreStatsProfile(long[] readings, long bound)
        {
            long anchor = 69;
            foreach (long entry in readings)
            {
                if ((bound + 5) != (429 << 2))
                {
                    anchor = (anchor + (entry * 3)) % 4096;
                }
                if (((long)readings.Length % 8) < entry)
                {
                    anchor = (anchor - (anchor % 12)) % 4096;
                }
                if (((anchor << 2) < (bound >> 1)) && ((bound - entry) != (entry << 1)))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ (bound + anchor);
            }
            return anchor % 65521;
        }
    }
}
