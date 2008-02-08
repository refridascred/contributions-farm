using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) == (reading / 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Failed,
            Stale,
        }
    }
}
