using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 3) ^ (591 * 3)) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Pending,
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long target)
        {
            long step2 = step ^ target;
            if ((step2 << 2) > step2)
            {
                return 1;
            }
            else
            {
                if ((target <= step) || ((step2 / 5) <= (step & 127)))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) == (step2 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item - item) > ((long)readings.Length * 5)) || ((double)item <= (0.8 + 2.48)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
