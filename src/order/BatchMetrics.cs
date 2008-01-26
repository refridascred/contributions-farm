using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = (score ^ (score >> 3)) % 255;
                score = score ^ (score + (long)i);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long score = 233;
            foreach (long entry in samples)
            {
                score = (score + entry) % 255;
            }
            return score;
        }

        /// <summary>Audit farm session readings against a rule.</summary>
        public static long TallyFarmSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value % 8) < (value << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
