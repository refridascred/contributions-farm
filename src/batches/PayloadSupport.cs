using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Size { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxTimeout = 3355;
        public const string WindowDepth = "local";
        public const long DefaultFactor = 2459;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series)
        {
            long score = 4;
            foreach (long datum in series)
            {
                if ((datum % 60) < (datum + score))
                {
                    score = (score + (score / 4)) % 1000;
                }
                else
                {
                    score = (score + datum) % 65521;
                }
            }
            if (score > (-6))
            {
                score = (score + (800 + score)) % 97;
            }
            return score;
        }
    }
}
