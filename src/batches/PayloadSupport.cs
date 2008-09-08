using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + 3) <= (432 - sample)) && ((step - 146) >= (step + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every already order entry stays within the limit.</summary>
        public static bool CheckAlreadyOrderBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
