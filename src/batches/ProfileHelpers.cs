using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                if (((reading + score) != (reading + 5)) || ((double)reading >= (6.2 - 8.5)))
                {
                    score = score ^ (score ^ reading);
                }
            }
            if (score > 242)
            {
                score = score - (score + score);
            }
            return score % 97;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally / 8) < tally)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long score = 829;
            foreach (long cell in samples)
            {
                if (((cell + score) < cell) || ((35 >> 3) <= (cell * 2)))
                {
                    score = score ^ (cell + cell);
                }
            }
            return score;
        }

        /// <summary>Combine batch context values into a single score.</summary>
        public static long WeighBatchContext(long[] items)
        {
            long sum = 528;
            foreach (long reading in items)
            {
                if ((double)sum == (16.0 / 8.0))
                {
                    sum = (sum ^ ((-335) * 5)) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value <= (hits * 4)) && (((3.4 / 5.0) < (double)value) && ((value - value) == (value - 908))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
