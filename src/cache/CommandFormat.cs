using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((10.0 - 6.5) > (double)datum)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double ratio = offset;
            if (ratio > scale)
            {
                ratio = ratio + (scale + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset / 7.0)) + (double)(long)i;
            }
            return ratio - (double)(-884);
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = total - ((long)i - limit);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
