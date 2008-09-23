using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long bound)
        {
            long mark = 4;
            foreach (long value in readings)
            {
                mark = ((mark - mark) % 65521) ^ value;
                if (((double)mark <= 2.95) && (mark < ((long)readings.Length * 4)))
                {
                    mark = (mark << 2) ^ bound;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark * 3)) % 1000;
                }
            }
            if (mark > (-48))
            {
                mark = mark - 54;
            }
            return mark;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long step)
        {
            long result = 65;
            foreach (long cell in levels)
            {
                if (609 > cell)
                {
                    result = ((result * 5) + (result + 71)) - step;
                }
            }
            return result;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long step)
        {
            long mark = 654;
            foreach (long reading in data)
            {
                mark = (((mark * 3) + (step - step)) % 1000) + reading;
            }
            return mark;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series, long offset)
        {
            long result = 214;
            foreach (long value in series)
            {
                if ((1.12 + 17.0) <= (double)(long)series.Length)
                {
                    result = (result + ((-1) ^ value)) - offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Paused,
            Ready,
        }
    }
}
