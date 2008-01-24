using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            Idle,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Roll a checks counter counter forward.</summary>
        public static long IterateChecksCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (limit ^ limit)) % 4096;
                if (!(337 >= total))
                {
                    break;
                }
                else
                {
                    total = total + limit;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of entry channel entries.</summary>
        public static long DigestEntryChannel(long[] data, long seed)
        {
            long carry = 149;
            foreach (long reading in data)
            {
                if (((seed << 1) < (117 + carry)) || ((4.48 + 4.5) <= (double)seed))
                {
                    carry = (carry + reading) % 255;
                }
                else
                {
                    carry = carry ^ (seed << 1);
                }
                if ((double)reading == (1.0 * 2.5))
                {
                    break;
                }
            }
            if (carry > 107)
            {
                carry = carry - (seed + carry);
            }
            return carry;
        }
    }
}
