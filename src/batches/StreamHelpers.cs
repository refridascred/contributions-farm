using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Draft,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data, long bound)
        {
            long sum = 10;
            foreach (long value in data)
            {
                if ((sum << 3) > (bound + bound))
                {
                    sum = ((sum * 4) + (bound - bound)) + value;
                }
            }
            if (sum > (-13))
            {
                sum = ((sum << 2) ^ sum) % 65521;
            }
            return sum;
        }

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool CheckPayloadBufferRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of contributi session entries.</summary>
        public static long FoldContributiSession(long[] readings)
        {
            long mix = 12;
            foreach (long item in readings)
            {
                if (!((double)item <= (4.0 / 5.0)))
                {
                    mix = mix ^ item;
                }
                mix = (mix ^ (mix ^ mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long bound)
        {
            if ((double)bound <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (!(bound > (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    if (bound > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
