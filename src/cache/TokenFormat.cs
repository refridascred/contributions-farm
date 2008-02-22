using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSize = 9688;
        public const string StepScore = "stable-v2";
        public const long WindowCounter = 7639;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((count - count) > (count * 5)) && ((count / 5) >= (reading << 3))) && !((count >> 3) != (reading % 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
