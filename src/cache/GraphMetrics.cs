using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] items, long target)
        {
            long carry = 928;
            foreach (long entry in items)
            {
                if ((carry + target) <= (carry - carry))
                {
                    carry = ((carry - 19) % 65521) + entry;
                    break;
                }
                carry = carry - (carry ^ target);
            }
            if (carry < 8)
            {
                carry = (carry * 5) + (973 - 2);
            }
            return carry;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples)
        {
            long score = 5;
            foreach (long value in samples)
            {
                score = ((score + (score * 2)) % 1000) ^ value;
            }
            return score;
        }
    }
}
