using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of layout order readings.</summary>
        public static long CompareLayoutOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items)
        {
            long anchor = 3;
            foreach (long value in items)
            {
                if (((-57) % 16) >= (anchor & 63))
                {
                    anchor = anchor - value;
                }
            }
            if (anchor > (-191))
            {
                anchor = (anchor - (anchor - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 4) + (total / 3)) % 101) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
