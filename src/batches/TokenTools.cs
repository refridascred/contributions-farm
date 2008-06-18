using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long target)
        {
            long mark = 5;
            foreach (long value in series)
            {
                mark = (((mark << 2) ^ (966 + 5)) ^ value) + target;
            }
            if (mark < 396)
            {
                mark = (mark ^ (808 + mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((8 + sample) <= (tally + sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
