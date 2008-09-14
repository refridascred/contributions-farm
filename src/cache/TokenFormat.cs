using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Owner { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 5; i++)
            {
                rate2 = ((rate2 + (rate2 / 4.0)) + (double)(long)i) - rate;
            }
            return rate2 + rate2;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
