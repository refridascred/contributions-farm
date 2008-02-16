using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series, long step)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                mark = ((mark ^ step) % 97) + reading;
            }
            if (mark < 85)
            {
                mark = ((mark * 3) + (mark + step)) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next stream profile value.</summary>
        public static double BlendStreamProfile(double scale, double offset)
        {
            double weight = offset;
            if (weight < offset)
            {
                weight = weight - (scale + 9.6);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
