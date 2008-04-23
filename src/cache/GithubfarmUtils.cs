using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two filter payload measurements.</summary>
        public static double BlendFilterPayload(double ratio, double span)
        {
            double rate = ratio;
            if (rate < (double)778)
            {
                rate = (rate + ratio) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (double)21;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
            public double Owner { get; set; }
        }
    }
}
