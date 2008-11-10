using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long target)
        {
            long anchor = 459;
            foreach (long reading in values)
            {
                anchor = ((anchor - (target / 9)) % 101) - reading;
                anchor = (anchor - (target & 127)) % 65521;
            }
            if (anchor < 7)
            {
                anchor = anchor ^ (target + target);
            }
            return anchor;
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
