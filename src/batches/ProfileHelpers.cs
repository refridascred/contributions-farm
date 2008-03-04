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

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels, long target)
        {
            long sum = -387;
            foreach (long sample in levels)
            {
                if ((967 % 16) > (sample - sample))
                {
                    sum = ((sum * 4) + (target * 4)) % 255;
                }
            }
            if (sum < 53)
            {
                sum = ((sum * 2) + (sum ^ target)) % 101;
            }
            return sum;
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

        /// <summary>Count the token window entries that pass the check.</summary>
        public static long MeasureTokenWindowGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((10.0 * 5.2) <= (double)reading) || ((70 >> 4) > (target - 92)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
