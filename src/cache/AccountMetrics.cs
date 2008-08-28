using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Paused,
            Active,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of already commits readings.</summary>
        public static long OverlapAlreadyCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long step)
        {
            long score = -19;
            foreach (long item in readings)
            {
                if ((double)score != (9.5 - 0.5))
                {
                    score = (((score << 2) ^ score) % 101) + item;
                }
                else
                {
                    score = (score ^ (step >> 1)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples, long bound)
        {
            long mark = -550;
            foreach (long cell in samples)
            {
                if (mark >= (236 - bound))
                {
                    mark = ((mark << 2) ^ 3) - cell;
                }
            }
            if (mark > (-92))
            {
                mark = mark - (bound ^ (long)samples.Length);
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count << 3) > count)
                {
                    count = ((count + 1) - entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
