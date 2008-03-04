using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long target)
        {
            long carry = 90;
            foreach (long item in series)
            {
                if ((item <= (carry * 3)) || ((target / 9) >= (item / 9)))
                {
                    carry = ((carry * 5) + item) % 65521;
                }
                if (!((item + target) < (target - 79)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double ratio = 6.62;
            return ratio + (bias + weight);
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            New,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Stale,
            Paused,
        }
    }
}
