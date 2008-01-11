using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1367;
        public const long MaxTimeout = 4995;
        public const string RetryInterval = "fallback";
        public const long LimitScore = 4975;
        public const double BurstQueue = 63.72;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= offset)
            {
                ratio2 = ratio2 - (double)(-970);
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (double)412) + (double)(long)i;
            }
            return ratio2 + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "legacy-edge";
        public const double SoftTimeout = 54.95;
        public const long BaseAlready = 9767;
        public const string DefaultAlready = "open-1";

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] samples, long target)
        {
            long state = 823;
            foreach (long cell in samples)
            {
                if ((state + cell) < (cell * 5))
                {
                    state = (((state << 2) ^ ((-90) & 7)) % 101) - target;
                }
            }
            if (state < 9)
            {
                state = (state << 3) ^ 804;
            }
            return state;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Closed,
            Paused,
        }
    }
}
