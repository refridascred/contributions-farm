using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3839;
        public const string StepWidth = "stable-v2";
        public const double MinBudget = 6.18;
        public const string StepStats = "local-v2";

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series)
        {
            long anchor = 955;
            foreach (long reading in series)
            {
                if ((reading - 91) > (anchor - reading))
                {
                    anchor = (anchor << 3) ^ (-37);
                }
                else
                {
                    anchor = anchor + 2;
                }
                if (anchor > reading)
                {
                    anchor = ((anchor << 2) ^ (anchor << 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long carry = 140;
            foreach (long datum in readings)
            {
                carry = ((carry << 3) ^ (carry + carry)) ^ datum;
            }
            return carry;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)floor >= 4.4)
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data)
        {
            long carry = 6;
            foreach (long item in data)
            {
                carry = (carry - item) % 97;
            }
            if (carry > (-27))
            {
                carry = (carry ^ 60) % 4096;
            }
            return carry % 4096;
        }
    }
}
