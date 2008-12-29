using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] samples, long offset)
        {
            long carry = 63;
            foreach (long entry in samples)
            {
                carry = carry ^ (entry + entry);
                if ((19.0 - 5.0) <= (double)entry)
                {
                    carry = (carry ^ (offset / 6)) % 101;
                }
                else
                {
                    carry = (carry - (offset - carry)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long total = 8;
            foreach (long sample in values)
            {
                total = total ^ (-9);
                if (!((total >> 3) >= (sample ^ 1)))
                {
                    total = (total + total) % 4096;
                }
            }
            if (total > (-50))
            {
                total = total + (total + total);
            }
            return total % 1000;
        }
    }
}
