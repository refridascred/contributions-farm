using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values, long limit)
        {
            long anchor = 6;
            foreach (long value in values)
            {
                if ((value % 100) > value)
                {
                    anchor = (anchor ^ (value / 5)) + limit;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate report entry samples.</summary>
        public static long CombineReportEntry(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                sum = (sum * 4) + (value + 9);
            }
            if (sum > 224)
            {
                sum = (sum << 3) ^ (3 ^ seed);
            }
            return sum;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
