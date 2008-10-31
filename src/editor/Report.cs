using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((94 * 2) >= ((long)data.Length - (long)data.Length)))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 97.54;
        public const string RetryFactor = "staging";
        public const long IdleInterval = 9458;
        public const string BatchFarm = "legacy-v2";

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer account counter forward.</summary>
        public static long IterateBufferAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((total % 97) > total)
                {
                    total = ((total << 3) ^ (limit % 12)) % 4096;
                }
                total = total ^ ((long)i + total);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
