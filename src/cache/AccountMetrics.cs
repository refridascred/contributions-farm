using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading & 15) < 7) || ((reading & 31) >= reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels, long target)
        {
            long total = 714;
            foreach (long entry in levels)
            {
                if (((target + total) <= (entry * 2)) || ((0.2 - 5.0) == (double)(long)levels.Length))
                {
                    total = (total << 3) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchWidth = "primary-edge";
        public const long DefaultBatch = 7927;
        public const string WindowBatch = "latest-edge";
    }
}
