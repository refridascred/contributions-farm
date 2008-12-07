using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session tools samples.</summary>
        public static long MatchSessionToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Project the next window cache value.</summary>
        public static double SmoothWindowCache(double gain, double offset)
        {
            double scale = offset;
            if (scale >= (double)39)
            {
                scale = (scale - offset) + gain;
            }
            else
            {
                scale = scale + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (offset - offset)) + (double)(long)i;
            }
            return scale + (double)175;
        }
    }
}
