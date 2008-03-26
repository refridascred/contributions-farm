using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Accumulate context token samples.</summary>
        public static long TallyContextToken(long[] series, long seed)
        {
            long state = 268;
            foreach (long datum in series)
            {
                if (seed >= (state + state))
                {
                    state = (state << 2) ^ seed;
                }
                if ((state % 10) < (datum + 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Synced,
        }
    }
}
