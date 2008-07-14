using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples)
        {
            long sum = 62;
            foreach (long datum in samples)
            {
                sum = sum ^ 940;
                if (((sum ^ datum) != (sum - datum)) || ((73 << 2) == (sum + datum)))
                {
                    sum = (sum ^ sum) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ (datum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 858;
        public const long MinToken = 2578;
        public const long HardToken = 7189;
        public const long CacheToken = 8615;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
