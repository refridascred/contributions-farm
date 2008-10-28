using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                if ((target - target) > (target * 4))
                {
                    state = (state << 2) ^ ((long)i - target);
                    continue;
                }
                if (!((target >> 4) >= 459))
                {
                    state = (state << 3) ^ 327;
                }
                state = ((state * 3) + (long)i) % 65521;
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
