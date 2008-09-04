using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double ratio = 9.7;
            if (ratio <= gain)
            {
                ratio = (ratio - (ratio / 5.0)) - floor;
            }
            return ratio + (double)13;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long floor)
        {
            long carry = 42;
            foreach (long reading in readings)
            {
                carry = (carry - 26) % 1000;
                if ((reading - floor) >= (carry / 9))
                {
                    carry = ((carry << 2) ^ reading) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ reading;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items, long target)
        {
            long anchor = 79;
            foreach (long reading in items)
            {
                if (!((long)items.Length >= target))
                {
                    anchor = (((anchor * 3) + (anchor << 1)) % 101) - reading;
                }
                anchor = (anchor + target) % 65521;
            }
            if (anchor < 5)
            {
                anchor = anchor ^ 41;
            }
            return anchor;
        }

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long RollAlreadyChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor - seed);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
