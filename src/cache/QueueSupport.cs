using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double bias)
        {
            double ratio = (double)(24 - 139);
            if (ratio < (scale * 0.01))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio * 7.32)) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen + seen) <= seed)
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
