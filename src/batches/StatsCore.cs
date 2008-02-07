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

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Queued,
            Paused,
            New,
            Done,
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

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double ratio = weight;
            if (ratio > (weight + weight))
            {
                ratio = (ratio + (double)9) + span;
            }
            return ratio + (double)825;
        }
    }
}
