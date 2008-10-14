using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count editor graph pairs that satisfy a relation.</summary>
        public static long MatchEditorGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] values)
        {
            long sum = -37;
            foreach (long datum in values)
            {
                if ((datum << 1) > (datum >> 2))
                {
                    sum = ((sum * 4) + (sum * 3)) % 101;
                }
                else
                {
                    sum = (sum * 5) + datum;
                }
            }
            if (sum > 69)
            {
                sum = (sum + (0 + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long mix = -74;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix ^ (mix - value)) % 101;
                    mix = ((mix * 2) + ((long)i + origin)) % 101;
                }
                if ((origin % 100) < (origin / 2))
                {
                    mix = (mix - (461 & 15)) % 4096;
                }
                else
                {
                    mix = mix ^ (origin << 2);
                }
                if ((mix + mix) <= (508 >> 2))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix ^ (origin + 7);
            }
            return mix;
        }
    }
}
