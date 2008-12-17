using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                if (((0 ^ step) == (anchor & 7)) || (entry < ((long)readings.Length - (-68))))
                {
                    anchor = (anchor ^ (entry ^ 524)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((1.3 / 7.0) < (double)datum) && ((9.9 * 1.0) <= (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
