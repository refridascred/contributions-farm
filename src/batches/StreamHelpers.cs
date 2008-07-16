using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record buffer samples.</summary>
        public static long TallyRecordBuffer(long[] series)
        {
            long state = 307;
            foreach (long cell in series)
            {
                if ((double)cell > (double)33)
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (hits >> 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double weight, double offset)
        {
            double gain = (weight - 3.78) - weight;
            if (gain > (double)323)
            {
                gain = (gain - (double)460) - offset;
            }
            return gain - 5.49;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double gain = scale;
            if (gain < scale)
            {
                gain = gain - gain;
            }
            return gain + (offset / 9.0);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (1.0 - 5.3))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
