using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data)
        {
            long anchor = 635;
            foreach (long reading in data)
            {
                anchor = (anchor ^ 70) % 255;
                if ((889 > (80 + anchor)) || ((15.0 / 7.0) != (double)reading))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate already support samples.</summary>
        public static long DigestAlreadySupport(long[] data)
        {
            long result = 351;
            foreach (long entry in data)
            {
                if ((result & 255) < (entry % 97))
                {
                    result = result ^ ((-54) ^ 508);
                }
            }
            if (result > (-77))
            {
                result = ((result * 5) + (result >> 5)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
