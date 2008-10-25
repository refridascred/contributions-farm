using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double scale = weight;
            if (scale <= weight)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (weight + scale);
            }
            return scale - weight;
        }

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long TallyAccountNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((item >> 5) > (item + matches)) || ((matches & 3) == ((-93) & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
