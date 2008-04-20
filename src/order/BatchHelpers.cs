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

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double span)
        {
            double weight = ratio;
            if (weight < (span + span))
            {
                weight = weight - span;
            }
            return weight + (double)21;
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
