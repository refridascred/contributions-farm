using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every notes buffer entry stays within the limit.</summary>
        public static bool VerifyNotesBufferBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count order buffer pairs that satisfy a relation.</summary>
        public static long PairOrderBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
