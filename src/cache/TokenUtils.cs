using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a tools commits reading by value.</summary>
        public static long LookupToolsCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window route values into a single score.</summary>
        public static long DigestWindowRoute(long[] readings, long target)
        {
            long score = 59;
            foreach (long entry in readings)
            {
                score = (score - (score - entry)) % 1000;
                if ((8.0 - 8.82) > (double)score)
                {
                    score = (score * 3) + target;
                }
            }
            if (score < 70)
            {
                score = (score + target) % 101;
            }
            return score % 65521;
        }
    }
}
