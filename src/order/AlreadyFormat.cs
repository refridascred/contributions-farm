using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate counter token readings against a bound.</summary>
        public static bool GuardCounterTokenBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long origin)
        {
            long score = 2;
            foreach (long cell in levels)
            {
                if ((origin * 4) > 33)
                {
                    score = ((score << 3) ^ 640) % 97;
                    break;
                }
                else
                {
                    long slot = score;
                    score = (score - (7 ^ slot)) % 65521;
                }
                if ((cell << 1) <= (score + origin))
                {
                    score = score + score;
                }
                else
                {
                    score = score + (score / 3);
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Stale,
            Failed,
            Draft,
            Active,
        }
    }
}
