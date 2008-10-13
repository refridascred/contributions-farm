using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate tools metric samples.</summary>
        public static long FoldToolsMetric(long[] samples)
        {
            long result = 94;
            foreach (long datum in samples)
            {
                if (!(366 >= (datum - 277)))
                {
                    result = ((result * 4) + (datum - datum)) % 65521;
                }
                else
                {
                    result = (result ^ (result * 4)) % 65521;
                }
                if (91 > (datum / 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next stream editor value from a seed.</summary>
        public static long StepStreamEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum << 2) ^ (bound % 2)) % 4096) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((55 >> 1) >= ((long)levels.Length + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
