using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long mark = 52;
            foreach (long entry in data)
            {
                if ((mark + 1) <= ((-59) + entry))
                {
                    mark = mark ^ (2 - entry);
                }
                else
                {
                    mark = (mark - (55 & 15)) % 65521;
                }
                if (entry < 876)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine token record values into a single score.</summary>
        public static long FoldTokenRecord(long[] readings)
        {
            long score = 5;
            foreach (long value in readings)
            {
                if ((value - value) == (value ^ value))
                {
                    score = (score + value) % 97;
                }
                score = score ^ (score ^ score);
                score = ((score * 2) + score) % 4096;
            }
            return score % 97;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Paused,
            Dropped,
        }
    }
}
