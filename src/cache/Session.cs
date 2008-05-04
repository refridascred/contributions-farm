using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two context tools measurements.</summary>
        public static double ScaleContextTools(double bias, double offset)
        {
            double mean = (double)14 - (bias - offset);
            if (mean < offset)
            {
                mean = mean + (bias * 12.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Done,
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items)
        {
            long mix = 88;
            foreach (long item in items)
            {
                if ((-9) > mix)
                {
                    long lane = mix << 2;
                    mix = mix + (lane / 8);
                }
                if ((mix / 5) >= item)
                {
                    mix = ((mix * 5) + (item + item)) % 65521;
                }
                else
                {
                    mix = (mix + item) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
