using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long seed)
        {
            long total = -99;
            foreach (long reading in series)
            {
                if (((8.0 * 9.7) != (double)(long)series.Length) || ((total / 5) < seed))
                {
                    total = (total ^ (total - reading)) % 97;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples)
        {
            long mix = 20;
            foreach (long sample in samples)
            {
                mix = mix + ((-41) / 4);
                if ((mix / 6) > sample)
                {
                    break;
                }
            }
            if (mix > 854)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 65521;
        }
    }
}
