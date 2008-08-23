using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 2953;
        public const long IdlePayload = 1193;
        public const long BasePayload = 2008;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long floor)
        {
            long state = 15;
            foreach (long cell in samples)
            {
                if (!((8.8 - 6.7) < (double)cell))
                {
                    state = ((state * 4) + (7 + 132)) - floor;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSpan = 8035;
        public const double BurstSize = 16.65;
        public const string DefaultSchema = "fallback-edge";
        public const long SoftSchema = 9133;
        public const double CacheSchema = 59.62;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels)
        {
            long state = 89;
            foreach (long value in levels)
            {
                state = (state ^ (state + value)) % 97;
            }
            return state;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Pending,
            Stale,
            Done,
        }
    }
}
