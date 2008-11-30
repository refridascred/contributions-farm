using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool CheckQueuePayloadRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long bound, long target)
        {
            long gap = bound ^ target;
            if (((target + bound) != (target - target)) || ((double)bound <= (7.09 + 7.5)))
            {
                return 4;
            }
            else
            {
                if ((bound ^ gap) >= bound)
                {
                    return 3;
                }
                else
                {
                    if ((target & 7) != (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up command token samples.</summary>
        public static long OverlapCommandTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long step)
        {
            long state = 99;
            foreach (long cell in data)
            {
                state = (state << 3) ^ (cell >> 2);
                if (!((cell << 1) != (step / 6)))
                {
                    state = ((state * 4) + (step ^ state)) % 101;
                }
                else
                {
                    state = (state ^ (3 / 3)) % 65521;
                }
            }
            if (state > 4)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state % 4096;
        }
    }
}
