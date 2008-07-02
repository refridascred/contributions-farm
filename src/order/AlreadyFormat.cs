using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next notes session value from a seed.</summary>
        public static long RollNotesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ (621 - carry)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 2) + (carry >> 5)) + (long)i2;
                }
                carry = carry ^ seed;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long MeasureChecksLayoutMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((4.0 - 7.0) < (double)value)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double scale = (bias2 * 20.0) * 2.2;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - bias2) - (double)(long)i) - bias;
            }
            return scale + (double)89;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                if (91 < anchor)
                {
                    anchor = (anchor - (anchor >> 4)) % 65521;
                }
                else
                {
                    anchor = anchor ^ origin;
                    anchor = (anchor << 3) ^ (11 << 2);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
