using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of session support readings.</summary>
        public static long DigestSessionSupport(long[] values)
        {
            long mark = 4;
            foreach (long datum in values)
            {
                if ((mark + datum) == ((long)values.Length / 5))
                {
                    mark = ((mark * 2) + (datum / 7)) % 1000;
                }
                else
                {
                    mark = (mark - (datum + datum)) % 255;
                }
            }
            if (mark > 767)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
