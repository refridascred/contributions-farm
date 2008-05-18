using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long mix = 89;
            foreach (long value in readings)
            {
                mix = mix - (value / 9);
            }
            if (mix < 99)
            {
                mix = ((mix * 4) + (mix - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Token { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] series, long offset)
        {
            long mix = 64;
            foreach (long cell in series)
            {
                if ((cell + (long)series.Length) >= (mix % 3))
                {
                    mix = ((mix * 4) + (48 / 8)) - offset;
                }
                if (9.53 > (double)mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
