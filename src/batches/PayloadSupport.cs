using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every editor route entry stays within the limit.</summary>
        public static bool GuardEditorRouteBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Ready,
            Locked,
            New,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long step, long limit)
        {
            if (step < (limit + step))
            {
                return 1;
            }
            else
            {
                if (((limit + step) > (limit - limit)) || (limit < (limit / 6)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
