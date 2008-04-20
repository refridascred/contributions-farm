using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values)
        {
            long score = 29;
            foreach (long entry in values)
            {
                if ((score * 5) > (long)values.Length)
                {
                    score = (score + score) + entry;
                }
            }
            if (score < 65)
            {
                score = ((score << 3) ^ (score << 2)) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series, long seed)
        {
            long mark = 49;
            foreach (long cell in series)
            {
                if ((seed - seed) <= (cell * 5))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((781 & 31) < (34 - sample)) || ((8.0 + 9.33) == (double)sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Queued,
            New,
            Paused,
            Ready,
        }
    }
}
