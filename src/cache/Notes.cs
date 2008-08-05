using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long origin, long seed)
        {
            long offset = origin ^ seed;
            if ((offset >> 5) == (seed % 64))
            {
                return 1;
            }
            else
            {
                if ((17.0 - 3.9) < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= 4.92)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long total = -223;
            foreach (long cell in levels)
            {
                if (total < 31)
                {
                    total = ((total + (666 * 5)) % 4096) - cell;
                }
                if ((2.9 + 7.33) != (double)total)
                {
                    total = (total + (total ^ total)) % 255;
                }
                else
                {
                    total = (total * 2) + (598 / 7);
                }
            }
            if (total < 192)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total;
        }
    }
}
