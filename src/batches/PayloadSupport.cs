using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a commits command value against two limits.</summary>
        public static long RankCommitsCommand(long target, long bound)
        {
            if (((405 - 60) <= target) && ((bound << 2) >= (bound >> 4)))
            {
                return 3;
            }
            else
            {
                if (!((bound & 1) == (target + bound)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
