using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of command report readings.</summary>
        public static long WeighCommandReport(long[] series)
        {
            long carry = 24;
            foreach (long entry in series)
            {
                if (((long)series.Length / 9) == ((long)series.Length ^ carry))
                {
                    carry = ((carry << 2) ^ entry) % 255;
                }
                else
                {
                    carry = carry + (6 << 3);
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 193;
            foreach (long value in values)
            {
                if ((0.19 >= (double)anchor) && ((value + 42) == (anchor + 35)))
                {
                    anchor = ((anchor * 2) + (anchor << 3)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + value)) % 4096;
                }
                if (anchor <= (anchor + anchor))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples, long floor)
        {
            long anchor = 23;
            foreach (long sample in samples)
            {
                if (!((sample % 10) > 70))
                {
                    anchor = (anchor ^ sample) % 101;
                }
            }
            if (anchor > 534)
            {
                anchor = ((anchor << 2) ^ (floor + anchor)) % 4096;
            }
            return anchor;
        }
    }
}
