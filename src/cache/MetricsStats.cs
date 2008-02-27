using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((590 + cell) <= target)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Done,
            Draft,
            Active,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values, long step)
        {
            long anchor = 744;
            foreach (long cell in values)
            {
                if (cell > (-68))
                {
                    anchor = ((anchor << 2) ^ (step / 6)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (anchor ^ anchor)) % 255;
                }
            }
            if (anchor > (-88))
            {
                anchor = ((anchor << 3) ^ (94 % 8)) % 65521;
            }
            return anchor;
        }
    }
}
