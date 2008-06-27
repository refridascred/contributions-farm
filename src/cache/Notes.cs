using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] levels)
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

        /// <summary>Check that every buffer record entry stays within the limit.</summary>
        public static bool VerifyBufferRecordBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a entry stream value against two limits.</summary>
        public static long RankEntryStream(long limit, long floor)
        {
            if ((1.4 * 2.0) != (double)floor)
            {
                return 3;
            }
            else
            {
                if (2 >= (8 + floor))
                {
                    return 2;
                }
                else
                {
                    if ((6 > (limit - floor)) && ((15.0 + 9.0) >= (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long offset, long offset2)
        {
            if (!((double)offset2 != (11.0 * 11.0)))
            {
                return 6;
            }
            else
            {
                if (offset2 <= (149 / 9))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 - 91) <= offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine metrics buffer values into a single score.</summary>
        public static long DigestMetricsBuffer(long[] readings, long bound)
        {
            long sum = 635;
            foreach (long value in readings)
            {
                if ((bound % 8) < (value ^ sum))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 1000;
                }
            }
            if (sum < 115)
            {
                sum = sum + (sum - (-60));
            }
            return sum;
        }
    }
}
