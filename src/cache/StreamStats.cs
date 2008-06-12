using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count context already pairs that satisfy a relation.</summary>
        public static long MatchContextAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long carry = 0;
            foreach (long reading in samples)
            {
                if (((carry ^ 55) >= reading) && ((double)reading <= 9.0))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
                else
                {
                    carry = (carry * 4) + (carry - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((2.21 + 13.0) <= (double)47)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
