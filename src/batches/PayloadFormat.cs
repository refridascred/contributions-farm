using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] samples, long target)
        {
            long score = 90;
            foreach (long cell in samples)
            {
                if ((cell - target) > (606 & 63))
                {
                    score = ((score << 2) ^ (cell - score)) % 255;
                }
            }
            if (score > 800)
            {
                score = (score - (target ^ score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long SortChecksCommits(long origin, long origin2)
        {
            long next = origin - origin2;
            if (!((next ^ 5) >= (origin2 - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin - origin2) > (origin2 + 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
