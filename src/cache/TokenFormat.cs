using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((seen - step) < (entry * 4)) && ((seen << 3) >= (entry * 2))) || ((step / 9) != ((long)items.Length - step)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)(long)i) + offset;
            }
            return drift + drift;
        }
    }
}
