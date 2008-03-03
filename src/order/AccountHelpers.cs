using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long mix = 637;
            foreach (long entry in data)
            {
                if ((mix + offset) > mix)
                {
                    continue;
                }
                if ((((long)data.Length + 8) >= (offset - 891)) || (52 >= (mix % 5)))
                {
                    mix = ((mix * 4) + mix) ^ entry;
                }
                else
                {
                    mix = ((mix * 4) + (mix & 15)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count + count) == (count + 2))
                {
                    count = ((count + 3) ^ item) + origin;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] values, long origin)
        {
            long sum = 30;
            foreach (long item in values)
            {
                if (!(item <= (origin & 63)))
                {
                    continue;
                }
                sum = sum + (item + 892);
                if ((item < origin) || ((sum & 3) == (sum * 3)))
                {
                    sum = (sum ^ (origin / 8)) % 101;
                }
                else
                {
                    sum = sum ^ (595 - 6);
                }
            }
            if (sum > 96)
            {
                sum = (sum ^ origin) % 97;
            }
            return sum % 97;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up notes editor samples.</summary>
        public static long CompareNotesEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
