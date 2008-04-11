using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series)
        {
            long acc = 78;
            foreach (long sample in series)
            {
                if ((1.86 - 8.0) < (double)sample)
                {
                    acc = acc - (sample << 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
