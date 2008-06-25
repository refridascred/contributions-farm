using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Queued,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long seed)
        {
            long carry = 51;
            foreach (long reading in values)
            {
                if (((reading - carry) <= (carry & 127)) && ((carry + 36) >= 97))
                {
                    carry = ((carry - (73 + carry)) % 255) - seed;
                }
                else
                {
                    carry = (carry * 4) + (carry >> 2);
                }
            }
            return carry % 97;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data, long step)
        {
            long carry = 1;
            foreach (long value in data)
            {
                if ((double)value < (6.0 - 9.8))
                {
                    carry = (carry << 2) ^ (step + step);
                }
            }
            if (carry < 85)
            {
                carry = ((carry << 2) ^ (step << 1)) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long DeriveEntryAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((acc >> 5) > (acc * 4))
                {
                    acc = (acc ^ (acc + 6)) % 97;
                    acc = acc - (long)i;
                }
                acc = acc - (acc ^ target);
                if ((target + (long)i) > (acc - (long)i))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
