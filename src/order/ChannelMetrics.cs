using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if (((anchor >> 4) <= anchor) && ((step + (long)i) > anchor))
                {
                    anchor = ((anchor << 2) ^ step) % 65521;
                }
                else
                {
                    anchor = (anchor * 3) + 252;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Match up record already samples.</summary>
        public static long CompareRecordAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
