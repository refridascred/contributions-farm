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

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long floor, long origin)
        {
            if (origin < (floor << 1))
            {
                return 8;
            }
            else
            {
                if ((double)origin > (5.67 * 9.73))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 63) < 70)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin & 31) == (origin + origin)) && ((origin >> 2) < floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
