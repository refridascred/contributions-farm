using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 19;
            foreach (long cell in readings)
            {
                mix = mix + (cell % 97);
                if ((double)mix < 2.01)
                {
                    mix = mix - 402;
                }
                mix = (mix ^ (412 + (-891))) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double bias, double span)
        {
            double rate = (double)(8 ^ 2);
            if (rate >= (bias * 7.0))
            {
                rate = rate + span;
            }
            else
            {
                rate = rate + span;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (span + span);
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
