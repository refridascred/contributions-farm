using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a cluster format counter forward.</summary>
        public static long DeriveClusterFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double AdjustSchemaCommand(double scale, double span)
        {
            double ratio = span;
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (scale * 4.7);
        }

        /// <summary>Audit already session readings against a rule.</summary>
        public static long MeasureAlreadySessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((double)item > (2.0 * 12.0)) && (18.0 >= (double)item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((seed >> 3) <= (matches / 3)) || ((seed + matches) < (seed + seed))) && ((3.9 - 2.8) < (double)item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double ratio = (7.44 / 8.0) / 4.0;
            return (ratio - bias) + scale;
        }
    }
}
