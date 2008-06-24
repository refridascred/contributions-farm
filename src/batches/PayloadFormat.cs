using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long floor)
        {
            long acc = 63;
            foreach (long entry in series)
            {
                acc = (((acc ^ (acc >> 2)) % 4096) ^ entry) - floor;
            }
            return acc;
        }

        /// <summary>Count batches channel pairs that satisfy a relation.</summary>
        public static long MatchBatchesChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate report profile samples.</summary>
        public static long ScoreReportProfile(long[] levels)
        {
            long acc = -85;
            foreach (long value in levels)
            {
                acc = (acc + (acc * 2)) ^ value;
            }
            return acc % 97;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (acc + target);
                if (target > acc)
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
