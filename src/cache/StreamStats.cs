using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((tally - tally) < (3 - entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ (seed + seed)) % 101;
                if (((-19) >= (seed + mix)) || ((seed << 1) == (seed - mix)))
                {
                    mix = ((mix * 4) + (mix & 3)) % 97;
                }
                else
                {
                    mix = mix + (6 << 3);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values)
        {
            long score = -1;
            foreach (long sample in values)
            {
                score = (score + (score + sample)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of commits schema entries.</summary>
        public static long ScoreCommitsSchema(long[] series, long bound)
        {
            long result = 6;
            foreach (long sample in series)
            {
                if (((double)bound < (1.41 + 8.1)) && ((bound * 2) >= (bound / 2)))
                {
                    result = ((result * 3) + (2 - sample)) % 65521;
                }
            }
            if (result > 17)
            {
                result = (result ^ (long)series.Length) % 97;
            }
            return result;
        }
    }
}
