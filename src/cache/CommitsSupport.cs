using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 2;
        public const double StepAlready = 82.72;
        public const long DefaultRatio = 1633;
        public const long CacheBudget = 8122;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                long cur = sum;
                long offset = (origin ^ (long)i) + (cur / 2);
                if (!(((sum + origin) < (origin - sum)) && (7 > (77 ^ origin))))
                {
                    cur = (cur << 3) ^ offset;
                    cur = ((cur << 2) ^ (sum + 36)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = (result - 953) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
