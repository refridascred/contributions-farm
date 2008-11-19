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

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long TallyPayloadTokenOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry % 16) >= (entry / 3))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
