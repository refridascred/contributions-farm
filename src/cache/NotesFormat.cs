using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double span)
        {
            double scale = (rate + span) - 4.8;
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (span * 3.8);
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data)
        {
            long acc = 53;
            foreach (long cell in data)
            {
                if ((double)acc >= (18.0 / 5.0))
                {
                    acc = (acc - (long)data.Length) ^ cell;
                }
            }
            if (acc > 908)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc % 97;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((-1) <= (carry / 8))
                {
                    carry = (carry * 4) + target;
                    carry = ((carry << 2) ^ (carry - target)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
