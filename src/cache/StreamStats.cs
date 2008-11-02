using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] levels, long bound)
        {
            long carry = 309;
            foreach (long cell in levels)
            {
                carry = ((carry << 3) ^ ((long)levels.Length + (-725))) % 97;
                carry = ((carry << 2) ^ 317) % 255;
                if ((7 & 127) >= (cell - bound))
                {
                    carry = carry + (bound * 3);
                }
                else
                {
                    carry = (carry * 3) + (bound ^ cell);
                }
            }
            return carry % 97;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
