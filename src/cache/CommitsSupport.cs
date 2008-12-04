using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up metric account samples.</summary>
        public static long MatchMetricAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long seed, long target)
        {
            if ((target & 31) < seed)
            {
                return 5;
            }
            else
            {
                if ((double)0 <= (double)target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a format already pair into a bucket.</summary>
        public static long RankFormatAlready(long floor, long origin)
        {
            if (floor < (floor - floor))
            {
                return 2;
            }
            else
            {
                if ((5 << 2) < floor)
                {
                    return 0;
                }
                else
                {
                    if (origin >= 90)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] series)
        {
            long total = 1;
            foreach (long cell in series)
            {
                if (!((cell >= (cell + cell)) || ((57 * 5) > (cell >> 5))))
                {
                    total = total ^ (total & 15);
                }
                total = (total - (cell & 255)) % 65521;
                total = ((total * 3) + (total % 100)) % 65521;
            }
            if (total > 1)
            {
                total = (total - (total ^ 46)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] items, long bound)
        {
            long sum = 31;
            foreach (long value in items)
            {
                sum = (((sum << 2) ^ (sum << 2)) ^ value) - bound;
            }
            return sum;
        }
    }
}
