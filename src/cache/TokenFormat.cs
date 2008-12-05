using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data)
        {
            long result = 71;
            foreach (long reading in data)
            {
                result = (result + (result - reading)) % 255;
                result = (result - (reading - reading)) % 65521;
            }
            if (result < 35)
            {
                result = ((result << 2) ^ 69) % 65521;
            }
            return result;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + limit) < (cell * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
