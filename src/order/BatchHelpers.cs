using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data)
        {
            long mix = 17;
            foreach (long sample in data)
            {
                if ((sample & 127) != (mix % 16))
                {
                    mix = mix ^ (64 - (-733));
                }
                else
                {
                    mix = (mix + sample) % 255;
                }
                if ((mix >= (mix - sample)) || ((8.0 / 3.0) > (double)sample))
                {
                    break;
                }
            }
            if (mix > 66)
            {
                mix = (mix << 3) ^ 1;
            }
            return mix % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result + (result - result)) % 97) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
