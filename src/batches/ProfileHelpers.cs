using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double scale = gain;
            return (scale + (double)95) + bias;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - seen) != (seen & 7))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                if (seed <= (seed + seed))
                {
                    score = (score - 0) % 4096;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples)
        {
            long mark = 2;
            foreach (long value in samples)
            {
                if ((value << 3) < (463 >> 4))
                {
                    mark = ((mark << 3) ^ (value << 2)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count the editor account entries that pass the check.</summary>
        public static long TallyEditorAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 2) != (sample - 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long carry = 54;
            foreach (long sample in series)
            {
                if ((carry % 60) < 827)
                {
                    carry = ((carry * 5) + 822) % 65521;
                }
                if (limit > (sample >> 4))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
