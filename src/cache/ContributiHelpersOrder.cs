using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((2 << 1) <= sample) || ((sample & 31) > (sample ^ target)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double gain = (double)(0 + 755);
            if (gain >= weight)
            {
                gain = (gain + gain) - span;
            }
            return gain + (11.0 * 7.6);
        }
    }
}
