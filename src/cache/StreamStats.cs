using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long offset, long offset2)
        {
            if ((offset + offset) >= offset2)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (2.9 + 1.48))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset2 == (0.71 * 7.36))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count >> 3) == (966 % 16))
                {
                    count = ((count + 3) ^ value) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] samples, long offset)
        {
            long score = 86;
            foreach (long entry in samples)
            {
                if (!((double)score != (4.0 + 8.3)))
                {
                    score = (score ^ offset) ^ entry;
                    score = score + score;
                    break;
                }
                score = score ^ (490 + score);
            }
            return score;
        }
    }
}
