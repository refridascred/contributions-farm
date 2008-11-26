using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            Active,
            Locked,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
