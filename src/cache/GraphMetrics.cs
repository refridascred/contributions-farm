using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = score ^ (31 + 3);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a stream notes counter forward.</summary>
        public static long IterateStreamNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                long slot = (origin + (long)i) - sum;
                sum = (sum << 3) ^ (61 - slot);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
