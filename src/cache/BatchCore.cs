using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry << 3) ^ (carry << 1)) % 101) - (long)i2;
                }
                if ((double)carry >= (17.0 - 4.0))
                {
                    carry = ((carry * 3) + (offset + carry)) % 97;
                }
                else
                {
                    carry = carry ^ (carry / 4);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= ratio)
            {
                ratio = (ratio + (ratio + rate)) - span;
            }
            return ratio + rate;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema notes pairs that satisfy a relation.</summary>
        public static long MatchSchemaNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
