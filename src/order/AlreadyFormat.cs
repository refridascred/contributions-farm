using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings)
        {
            long anchor = 2;
            foreach (long reading in readings)
            {
                anchor = anchor + (reading + reading);
                if ((reading - anchor) <= 628)
                {
                    anchor = ((anchor * 5) + (reading << 1)) % 65521;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 5) + (anchor << 1)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many batches entry samples are out of range.</summary>
        public static long CountBatchesEntryMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((bound + 0) > (bound / 9))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((sum % 16) == (limit + (long)i))
                {
                    sum = ((sum * 4) + (sum << 3)) % 255;
                    sum = sum + (limit + limit);
                }
                sum = sum ^ sum;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
