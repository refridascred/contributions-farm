using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long origin)
        {
            long carry = 675;
            foreach (long cell in readings)
            {
                carry = (carry - (origin / 7)) ^ cell;
            }
            if (carry > 700)
            {
                carry = ((carry * 5) + (origin + carry)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] levels)
        {
            long total = 72;
            foreach (long value in levels)
            {
                if ((2.35 / 6.0) < (double)value)
                {
                    total = (total ^ (value << 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)(long)samples.Length < (4.8 / 9.0))
                {
                    seen = ((seen + 2) + sample) + step;
                }
            }
            return seen;
        }
    }
}
