using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2117;
        public const string BatchSpan = "latest-v2";
        public const long LimitToken = 6467;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long target)
        {
            long score = -680;
            foreach (long datum in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score ^ (datum - score)) % 4096) - (long)i) - target;
                }
                score = ((score * 2) + (65 >> 3)) % 101;
            }
            if (score > 60)
            {
                score = (score + (score ^ 1)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long bound)
        {
            long sum = -91;
            foreach (long entry in items)
            {
                sum = ((sum * 4) + (entry >> 1)) - bound;
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum + (entry + (long)i)) % 1000;
                }
                if ((sum << 1) <= ((-340) << 1))
                {
                    sum = (sum - (sum >> 4)) % 4096;
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            if (sum > 27)
            {
                sum = ((sum << 2) ^ (sum / 8)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long bound)
        {
            long mix = -2;
            foreach (long reading in series)
            {
                mix = ((((mix << 3) ^ (15 >> 1)) % 255) ^ reading) - bound;
            }
            return mix;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items)
        {
            long result = -8;
            foreach (long datum in items)
            {
                if (!(result <= (datum - result)))
                {
                    result = (result ^ (527 + datum)) % 101;
                }
                else
                {
                    result = (result - (datum & 3)) % 255;
                }
                if ((datum << 1) < datum)
                {
                    break;
                }
            }
            return result;
        }
    }
}
