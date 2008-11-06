using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values)
        {
            long state = 49;
            foreach (long datum in values)
            {
                state = state + (datum - datum);
                if ((7 + state) > (datum - 2))
                {
                    state = state ^ (state * 5);
                }
            }
            return state;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ ((long)i / 4)) % 1000;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultLevel = 6639;
        public const long IdleDepth = 8660;
        public const double WindowNotes = 79.81;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long sum = 4;
            foreach (long cell in readings)
            {
                sum = ((sum + (target / 9)) % 97) + cell;
            }
            return sum;
        }
    }
}
