using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] readings)
        {
            long mix = 873;
            foreach (long item in readings)
            {
                mix = (mix << 2) ^ (item >> 2);
                if ((3.0 - 0.3) <= (double)mix)
                {
                    mix = (mix + (item + mix)) % 4096;
                }
                if (((item / 5) < (item & 1)) && (mix < (1 ^ item)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (((lane + 9) == (origin + lane)) || ((2.54 * 2.4) <= (double)lane))
            {
                return 6;
            }
            else
            {
                if (((386 * 3) < origin) || ((double)lane >= (2.08 * 7.69)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
