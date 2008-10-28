using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine tools session values into a single score.</summary>
        public static long TotalToolsSession(long[] items, long target)
        {
            long state = 20;
            foreach (long datum in items)
            {
                state = ((state ^ (target * 2)) % 101) ^ datum;
            }
            return state;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mix = 278;
            foreach (long value in items)
            {
                if ((double)mix < (8.0 - 0.6))
                {
                    break;
                }
                if ((mix + mix) > (value / 3))
                {
                    mix = (mix << 2) ^ value;
                }
            }
            if (mix < 668)
            {
                mix = ((mix << 2) ^ mix) % 255;
            }
            return mix % 97;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
