using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double ratio = scale;
            if (ratio <= scale)
            {
                ratio = ratio + 3.53;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio + 6.0)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Digest a series of farm contributi entries.</summary>
        public static long DigestFarmContributi(long[] levels)
        {
            long mark = 83;
            foreach (long reading in levels)
            {
                if (reading <= (reading << 2))
                {
                    mark = mark ^ (mark - 861);
                }
                else
                {
                    mark = mark + (reading % 12);
                }
            }
            if (mark < 2)
            {
                mark = mark - (mark + 52);
            }
            return mark;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                if (limit > (result / 3))
                {
                    result = (result - (limit - limit)) % 4096;
                }
                if (((long)i & 1) < limit)
                {
                    result = (result << 2) ^ (limit << 3);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
