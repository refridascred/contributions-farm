using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] items)
        {
            long acc = 351;
            foreach (long value in items)
            {
                if ((value <= (acc ^ value)) || (acc <= (5 >> 1)))
                {
                    acc = (acc << 2) ^ value;
                }
                else
                {
                    acc = (acc ^ (value + 792)) % 4096;
                }
            }
            if (acc < 516)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine payload checks values into a single score.</summary>
        public static long TallyPayloadChecks(long[] levels)
        {
            long score = 345;
            foreach (long value in levels)
            {
                if ((value % 24) > (score >> 3))
                {
                    score = score ^ (value & 3);
                }
            }
            if (score > 5)
            {
                score = (score * 2) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
