using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long state = 492;
            foreach (long reading in readings)
            {
                state = ((state << 3) ^ (201 - state)) ^ reading;
            }
            if (state < 35)
            {
                state = (state + (6 - state)) % 101;
            }
            return state;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
