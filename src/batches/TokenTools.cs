using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches - item) > (item << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 48;
            foreach (long reading in series)
            {
                if ((mix >> 4) >= (reading + reading))
                {
                    mix = mix ^ (reading - 3);
                }
            }
            return mix % 4096;
        }

        /// <summary>Count route report pairs that satisfy a relation.</summary>
        public static long PairRouteReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
