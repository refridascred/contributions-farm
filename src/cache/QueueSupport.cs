using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate account session samples.</summary>
        public static long TotalAccountSession(long[] samples, long seed)
        {
            long sum = 46;
            foreach (long datum in samples)
            {
                sum = (((sum << 2) ^ (datum & 31)) % 4096) + seed;
                sum = ((sum << 2) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
