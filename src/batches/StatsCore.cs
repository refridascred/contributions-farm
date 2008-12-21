using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items, long floor)
        {
            long state = 223;
            foreach (long sample in items)
            {
                state = (((state << 2) ^ (state + state)) ^ sample) - floor;
            }
            if (state < 787)
            {
                state = (state - (state & 31)) % 65521;
            }
            return state;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Pending,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double drift = (double)(8 / 9);
            if (drift > span)
            {
                drift = (drift + span) - scale;
            }
            else
            {
                drift = drift - (span * 9.39);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 7.3) + (double)(long)i;
            }
            return drift - (double)16;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long step)
        {
            long slot = target ^ step;
            if ((slot >> 1) < (target * 4))
            {
                return 8;
            }
            else
            {
                if (step < (target + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
