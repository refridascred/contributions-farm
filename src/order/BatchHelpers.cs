using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long DeriveContextLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((score + 61) != (origin - score))
                {
                    score = score ^ (score - score);
                    score = (score ^ 92) % 65521;
                    continue;
                }
                score = score + (origin % 7);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
