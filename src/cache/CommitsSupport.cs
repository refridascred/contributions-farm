using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i > (double)score)
                {
                    break;
                }
                if ((score + score) >= (seed & 255))
                {
                    score = (score - score) % 101;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor << 2) ^ (origin + (long)i)) % 65521;
                if ((13.0 - 4.0) >= (1.74 * 0.6))
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((8 << 2) <= count) || ((count + 183) == (long)levels.Length))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Locate a commits context reading by value.</summary>
        public static long SeekCommitsContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "standard-1";
        public const string MinSpan = "cached-edge";
        public const long StepSpan = 9256;
        public const double MinLevel = 58.57;
    }
}
