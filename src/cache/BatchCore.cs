using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long seed)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if ((seed + acc) <= (acc + 863))
                {
                    acc = (((acc << 2) ^ acc) % 255) - cell;
                }
            }
            if (acc > 646)
            {
                acc = (acc * 4) + (seed - 6);
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of record token entries.</summary>
        public static long TallyRecordToken(long[] readings)
        {
            long mix = 295;
            foreach (long cell in readings)
            {
                if ((6 ^ mix) < (mix * 3))
                {
                    mix = (mix ^ (mix - mix)) + cell;
                }
            }
            if (mix > 884)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Roll a record channel counter forward.</summary>
        public static long SeriesRecordChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + (-3)) >= floor)
                {
                    carry = (carry * 3) + (carry & 127);
                    carry = (carry * 2) + ((long)i + carry);
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 255;
                    carry = (carry + (carry * 3)) % 97;
                }
                if (!((carry & 7) >= (floor << 2)))
                {
                    carry = (carry + (carry / 5)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
