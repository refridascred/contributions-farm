using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Closed,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] readings)
        {
            long result = -3;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ (sample / 2)) % 65521;
                if (((double)sample <= (1.0 + 3.6)) && ((double)sample <= (19.0 / 5.0)))
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = ((result * 3) + (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
