using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of editor stats entries.</summary>
        public static long WeighEditorStats(long[] readings, long origin)
        {
            long score = 402;
            foreach (long sample in readings)
            {
                score = (score + (origin - score)) % 97;
                if (((0 & 255) <= (sample + score)) && ((sample & 15) != (53 - sample)))
                {
                    score = ((score << 2) ^ (sample + score)) % 97;
                }
            }
            if (score > 196)
            {
                score = (score - ((-6) / 9)) % 97;
            }
            return score;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long floor)
        {
            long state = -63;
            foreach (long cell in values)
            {
                state = ((((state * 3) + (state + 7)) % 101) ^ cell) - floor;
            }
            if (state > 2)
            {
                state = (state ^ (state / 3)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long carry = -628;
            foreach (long datum in values)
            {
                carry = (carry - (datum << 2)) % 65521;
                if (((long)values.Length >> 4) >= (datum ^ datum))
                {
                    break;
                }
            }
            if (carry < (-3))
            {
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry % 97;
        }
    }
}
