using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((cell - 131) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout account sample.</summary>
        public static long SeekLayoutAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item < (6.0 / 3.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
