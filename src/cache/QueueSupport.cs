using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Draft,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data, long step)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                mix = ((mix * 4) + (mix - step)) % 97;
                if ((step / 5) <= entry)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Grade a entry already value against two limits.</summary>
        public static long RankEntryAlready(long bound, long limit)
        {
            if ((8.24 * 1.81) == (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound > (limit + 269)) || ((bound >> 5) >= (limit << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
