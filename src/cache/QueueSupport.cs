using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((18.0 - 0.54) > (2.0 * 0.81))
                {
                    score = (score - (score % 24)) % 1000;
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
