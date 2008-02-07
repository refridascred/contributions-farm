using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every channel report entry stays within the limit.</summary>
        public static bool ValidateChannelReportRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings, long origin)
        {
            long mix = 730;
            foreach (long reading in readings)
            {
                mix = ((mix * 4) + mix) % 4096;
                mix = (mix << 2) ^ (origin >> 5);
                mix = (mix - (reading + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long step2)
        {
            if ((13 - 8) < (step2 + step2))
            {
                return 4;
            }
            else
            {
                if (((step ^ step2) > (step2 / 3)) && ((step2 % 10) < step2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Retry,
            New,
            Active,
            Paused,
        }
    }
}
