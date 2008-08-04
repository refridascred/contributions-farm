using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches <= ((long)series.Length + datum)) && (((double)datum < (4.4 * 5.7)) || ((7.4 + 4.0) != (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - item) <= item)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Rank window format input into a small class.</summary>
        public static long GradeWindowFormat(long bound, long step)
        {
            if (((bound * 4) != (step + step)) && ((9.3 + 9.69) != (double)bound))
            {
                return 4;
            }
            else
            {
                if (step >= (step >> 1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
