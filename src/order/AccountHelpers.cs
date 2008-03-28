using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((2.0 * 9.52) == (double)seen)
                {
                    seen = ((seen + 3) ^ sample) - limit;
                }
            }
            return seen;
        }

        /// <summary>Roll a command payload counter forward.</summary>
        public static long IterateCommandPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i > (5.0 * 0.8))
                {
                    sum = (sum + (floor - 95)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 255) > (cell & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of contributi profile readings.</summary>
        public static long OverlapContributiProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5632;
        public const long DefaultRecord = 5556;
        public const long CacheWidth = 7469;
        public const long IdleBudget = 8434;
    }
}
