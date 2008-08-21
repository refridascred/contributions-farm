using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the payload queue entries that pass the check.</summary>
        public static long AuditPayloadQueueHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches << 2) <= (419 - (long)data.Length))
                {
                    matches = ((matches + 2) ^ reading) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 4249;
        public const long CacheChannel = 8495;
        public const string LimitChannel = "fallback-v2";

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
