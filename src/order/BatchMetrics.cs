using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ offset) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen < (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a support commits counter forward.</summary>
        public static long StepSupportCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= (868 >> 2))
                {
                    score = (score ^ 380) % 101;
                    continue;
                }
                if ((666 ^ limit) <= limit)
                {
                    score = ((score << 2) ^ (long)i) % 4096;
                }
                else
                {
                    score = score ^ (limit + score);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values, long origin)
        {
            long score = 0;
            foreach (long entry in values)
            {
                if ((origin / 3) != (score / 9))
                {
                    score = score - (602 / 5);
                }
                else
                {
                    score = score - (entry << 3);
                }
            }
            return score;
        }
    }
}
