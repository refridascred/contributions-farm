using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (step > (step + step))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((sum + sum) < offset)
                {
                    sum = ((sum * 2) + (sum % 12)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
