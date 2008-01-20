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

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            New,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
