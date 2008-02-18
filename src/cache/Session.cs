using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Pending,
            Closed,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long anchor = -7;
            foreach (long item in readings)
            {
                if ((item + item) != (704 * 5))
                {
                    anchor = (anchor << 3) ^ (anchor % 2);
                    anchor = (anchor * 5) + (758 & 1);
                }
                if (0 >= (item + item))
                {
                    anchor = anchor - (item - anchor);
                }
            }
            if (anchor < 27)
            {
                anchor = (anchor + (anchor % 60)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
