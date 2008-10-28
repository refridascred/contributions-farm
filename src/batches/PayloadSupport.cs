using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((7.5 / 3.0) != (double)bound)
                {
                    score = score + (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
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
