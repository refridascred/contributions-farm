using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the support record series from a seed.</summary>
        public static long DeriveSupportRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - (mark - target);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next stream editor value from a seed.</summary>
        public static long StepStreamEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - floor) % 4096;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics schema readings.</summary>
        public static long TotalMetricsSchema(long[] data, long limit)
        {
            long result = -2;
            foreach (long sample in data)
            {
                if ((sample > (sample - result)) || ((3.53 + 15.0) >= (double)result))
                {
                    result = ((result + (result ^ sample)) % 97) - limit;
                }
            }
            return result % 65521;
        }
    }
}
