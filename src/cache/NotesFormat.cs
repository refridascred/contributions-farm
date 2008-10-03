using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long bound)
        {
            long score = 5;
            foreach (long sample in levels)
            {
                if (((4.55 / 5.0) != (double)score) && (sample < score))
                {
                    score = (score ^ 548) % 4096;
                    score = (score + (bound << 1)) % 4096;
                }
                score = (score - (bound ^ bound)) % 65521;
            }
            if (score < 9)
            {
                score = (score + (356 - score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long target)
        {
            long mark = 910;
            foreach (long value in data)
            {
                if ((double)value <= (double)99)
                {
                    mark = ((mark * 2) + (mark & 7)) % 255;
                    mark = (mark ^ 60) % 1000;
                    continue;
                }
                else
                {
                    mark = (mark + (value % 60)) % 4096;
                }
                if (target > (mark - mark))
                {
                    mark = mark + (16 ^ value);
                }
            }
            if (mark > (-702))
            {
                mark = (mark << 3) ^ (target >> 2);
            }
            return mark % 1000;
        }
    }
}
