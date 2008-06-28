using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values)
        {
            long mix = 444;
            foreach (long sample in values)
            {
                if ((double)mix != (3.5 + 8.44))
                {
                    mix = ((mix << 2) ^ (sample & 63)) % 65521;
                }
            }
            if (mix > 50)
            {
                mix = mix ^ (mix % 5);
            }
            return mix;
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long AuditNotesFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (8.0 <= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((-53) + 66) != (sample + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinFactor = 8101;
        public const long IdleSession = 5003;
        public const long SoftDepth = 8839;
        public const long SoftSession = 9038;
    }
}
