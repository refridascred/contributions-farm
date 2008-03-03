using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings, long step)
        {
            long score = 740;
            foreach (long datum in readings)
            {
                score = (((score << 3) ^ (score % 16)) % 1000) ^ datum;
                if ((39 / 3) == (score % 60))
                {
                    score = ((score << 2) ^ (step - 82)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long mix = -71;
            foreach (long item in series)
            {
                mix = (mix ^ (mix & 255)) + item;
            }
            return mix;
        }
    }
}
