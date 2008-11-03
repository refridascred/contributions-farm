using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data)
        {
            long result = -8;
            foreach (long reading in data)
            {
                result = ((result * 5) + (reading - reading)) % 1000;
                result = (result - (reading << 3)) % 65521;
            }
            if (result > 65)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < (double)93)
            {
                ratio = (ratio + offset) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (7.4 + offset)) - (double)(long)i;
            }
            return ratio + (double)(-5);
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 5486;
        public const long BurstSize = 460;
        public const long BaseSize = 6851;
        public const long MaxCommits = 7580;
        public const double BatchCommits = 52.95;
    }
}
