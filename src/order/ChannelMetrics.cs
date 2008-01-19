using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] values)
        {
            long result = -3;
            foreach (long reading in values)
            {
                if ((reading % 100) < result)
                {
                    result = result ^ (428 + result);
                }
                else
                {
                    result = (result << 2) ^ (reading * 3);
                }
            }
            return result % 97;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) > 41)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
