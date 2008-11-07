using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double mean = bias * 8.8;
            if (mean < (double)(-8))
            {
                mean = mean - (double)9;
            }
            else
            {
                mean = mean + (gain - mean);
            }
            return mean + mean;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((4 % 12) > (value << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                mix = mix ^ (63 + mix);
                mix = ((mix << 2) ^ (reading - 53)) % 4096;
            }
            if (mix < 9)
            {
                mix = ((mix * 2) + (mix - 671)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((origin % 10) < (origin - origin))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
