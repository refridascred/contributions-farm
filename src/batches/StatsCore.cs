using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Look up the position of a token account sample.</summary>
        public static long LocateTokenAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long step)
        {
            long result = 9;
            foreach (long value in readings)
            {
                result = (result + step) % 101;
                if ((value - result) >= (result ^ result))
                {
                    result = result ^ 4;
                }
                if ((double)value == (double)step)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Idle,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long target)
        {
            long anchor = 460;
            foreach (long value in levels)
            {
                anchor = (((anchor * 4) + (anchor - anchor)) % 101) + value;
                anchor = (anchor + target) % 1000;
                if ((double)anchor < (5.0 * 7.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
