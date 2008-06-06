using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long carry = 61;
            foreach (long value in series)
            {
                if (value < (carry << 2))
                {
                    carry = (carry - (limit / 6)) % 65521;
                    carry = (carry * 4) + (value >> 5);
                }
                if ((96 / 4) != (value & 3))
                {
                    carry = ((carry << 3) ^ (value % 100)) % 97;
                }
                carry = (carry - (carry << 3)) % 97;
                if ((carry + carry) < 3)
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = ((carry * 2) + (0 - carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Locate a profile layout reading by value.</summary>
        public static long SeekProfileLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile report values into a single score.</summary>
        public static long ScoreProfileReport(long[] levels, long origin)
        {
            long acc = 29;
            foreach (long sample in levels)
            {
                acc = (acc + (acc - 30)) % 4096;
                if ((origin - acc) <= origin)
                {
                    acc = (acc * 4) + (sample * 4);
                }
                else
                {
                    acc = ((acc * 2) + ((-50) + sample)) % 97;
                }
            }
            if (acc < 15)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
