using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many already queue samples are out of range.</summary>
        public static long AuditAlreadyQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(((item ^ item) >= (matches << 3)) || ((double)item != (8.02 - 3.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long seed)
        {
            long acc = 801;
            foreach (long value in data)
            {
                if (12.0 <= (double)acc)
                {
                    acc = (acc << 2) ^ value;
                }
            }
            if (acc > (-417))
            {
                acc = acc + (320 + seed);
            }
            return acc;
        }
    }
}
