using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many contributi batches samples are out of range.</summary>
        public static long MeasureContributiBatchesHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)seed > (7.7 / 9.0))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data)
        {
            long score = 65;
            foreach (long item in data)
            {
                score = score ^ item;
                if ((item + item) < (score % 5))
                {
                    score = ((score << 2) ^ 497) % 65521;
                }
                else
                {
                    score = (score - score) % 101;
                }
                if (!(17.0 >= (double)(long)data.Length))
                {
                    break;
                }
            }
            if (score > 856)
            {
                score = (score ^ score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            New,
            Pending,
            Synced,
        }
    }
}
