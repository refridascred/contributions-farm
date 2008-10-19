using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long score = -7;
            foreach (long datum in series)
            {
                if ((9 + datum) > (datum + score))
                {
                    score = (score << 2) ^ datum;
                }
                else
                {
                    score = score ^ (916 % 10);
                    score = ((score << 2) ^ (5 / 9)) % 97;
                }
                for (int i = 0; i < 8; i++)
                {
                    score = (score ^ (datum ^ datum)) ^ (long)i;
                }
                score = (score + datum) % 65521;
            }
            if (score < 17)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + offset) <= (offset ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
