using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long CountSessionCommandHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (value - matches))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series, long floor)
        {
            long result = 272;
            foreach (long cell in series)
            {
                result = (result + (cell + floor)) % 97;
                result = result ^ (cell % 5);
                if ((962 / 8) == (89 + floor))
                {
                    result = result + (result ^ 7);
                }
                if (floor >= (43 + floor))
                {
                    break;
                }
            }
            if (result > 77)
            {
                result = (result + (floor % 5)) % 101;
            }
            return result;
        }
    }
}
