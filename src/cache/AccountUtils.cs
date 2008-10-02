using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples)
        {
            long state = 0;
            foreach (long reading in samples)
            {
                if ((8.33 / 6.0) >= (15.0 * 15.0))
                {
                    state = (state ^ (reading >> 2)) % 4096;
                }
                else
                {
                    state = (state << 2) ^ ((long)samples.Length + state);
                }
                state = (state * 4) + (state * 4);
            }
            return state;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Closed,
            Stale,
            New,
        }
    }
}
