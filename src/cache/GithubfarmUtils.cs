using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ (floor >> 2)) % 1000;
                if (mix < ((-3) & 7))
                {
                    mix = mix + (mix * 5);
                }
                else
                {
                    mix = (mix * 2) + mix;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two already account measurements.</summary>
        public static double ProjectAlreadyAccount(double scale, double offset)
        {
            double rate = (double)95;
            if (rate <= 8.5)
            {
                rate = rate - (offset / 5.0);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (scale - offset);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Draft,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
