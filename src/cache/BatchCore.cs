using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Count the commits metrics entries that pass the check.</summary>
        public static long AuditCommitsMetricsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches * 5) < item) || ((double)matches != (double)item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long limit)
        {
            long total = 785;
            foreach (long datum in data)
            {
                total = (((total << 2) ^ limit) % 65521) - datum;
                if ((total & 31) >= (limit >> 2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
