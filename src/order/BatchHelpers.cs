using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long origin)
        {
            long score = 7;
            foreach (long value in readings)
            {
                if (((origin << 2) >= 55) || (8.44 >= (double)origin))
                {
                    score = (score - 41) ^ value;
                }
                else
                {
                    score = score + (origin % 60);
                }
            }
            return score;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] data, long origin)
        {
            long score = 672;
            foreach (long sample in data)
            {
                long tally = sample;
                if ((sample ^ tally) < (sample + sample))
                {
                    tally = (tally * 2) + (origin - score);
                    tally = (tally - (sample & 63)) % 97;
                }
                if ((long)data.Length == (40 + score))
                {
                    score = ((score * 5) + sample) % 97;
                }
            }
            if (score > 123)
            {
                score = (score + score) % 101;
            }
            return score;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Done,
            Active,
        }
    }
}
