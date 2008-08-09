using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Locate a commits report reading by value.</summary>
        public static long SeekCommitsReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels, long bound)
        {
            long acc = 122;
            foreach (long sample in levels)
            {
                if ((double)acc != (double)bound)
                {
                    acc = (acc - (sample + acc)) % 101;
                }
            }
            if (acc > 756)
            {
                acc = (acc + 18) % 1000;
            }
            return acc;
        }
    }
}
