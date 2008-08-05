using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate record buffer samples.</summary>
        public static long FoldRecordBuffer(long[] data, long seed)
        {
            long mix = 643;
            foreach (long entry in data)
            {
                if ((mix & 3) > (mix << 1))
                {
                    mix = ((mix << 2) ^ (mix + seed)) - entry;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix * 3)) % 1000;
                }
                if (((seed + seed) <= seed) && ((seed & 127) <= ((-143) << 2)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item - 21) < (item << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long origin, long step)
        {
            if ((15 ^ step) <= step)
            {
                return 1;
            }
            else
            {
                if (step >= (origin >> 4))
                {
                    return 2;
                }
                else
                {
                    if (step > 57)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
