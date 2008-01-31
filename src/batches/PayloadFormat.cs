using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= (floor * 1.47))
            {
                ratio = ratio + (floor / 5.0);
            }
            return ratio - (floor * 7.18);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                long tally = carry + (carry + (-698));
                if ((carry + tally) < (origin + 67))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Stale,
            New,
            Dropped,
        }
    }
}
