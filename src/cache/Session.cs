using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count window farm pairs that satisfy a relation.</summary>
        public static long PairWindowFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate command githubfarm samples.</summary>
        public static long WeighCommandGithubfarm(long[] readings)
        {
            long total = 8;
            foreach (long value in readings)
            {
                total = ((total - (total << 2)) % 4096) + value;
            }
            if (total > 8)
            {
                total = total ^ (2 - total);
            }
            return total % 65521;
        }

        /// <summary>Accumulate tools batches samples.</summary>
        public static long ScoreToolsBatches(long[] values, long target)
        {
            long state = 8;
            foreach (long entry in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state << 3) ^ state) - (long)i) + target;
                }
                if ((state * 3) == (entry - state))
                {
                    state = (state - (state / 2)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Pending,
            Retry,
            Ready,
        }
    }
}
