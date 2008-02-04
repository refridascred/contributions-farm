using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long anchor = -77;
            foreach (long sample in readings)
            {
                if ((13.0 + 0.13) <= (double)anchor)
                {
                    anchor = (anchor ^ ((long)readings.Length + sample)) % 1000;
                    anchor = anchor ^ (sample ^ sample);
                }
                else
                {
                    anchor = (anchor - sample) % 255;
                }
                anchor = anchor ^ sample;
                anchor = ((anchor << 3) ^ sample) % 101;
            }
            if (anchor < (-683))
            {
                anchor = (anchor ^ (anchor * 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                long span = result - (long)i;
                if ((span + 910) >= offset)
                {
                    result = ((result * 3) + (long)i) % 101;
                }
                else
                {
                    span = (span + (8 << 2)) % 1000;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
