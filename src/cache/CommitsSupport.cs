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

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
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
