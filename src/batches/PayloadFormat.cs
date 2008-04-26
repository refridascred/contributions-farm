using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long step)
        {
            long edge = floor + step;
            if (((62 >> 2) != (9 ^ floor)) && ((edge << 3) >= (step + 4)))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (5.0 * 14.0))
                {
                    return 3;
                }
                else
                {
                    if (step <= (step % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor > (0 + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long sum = 6;
            foreach (long sample in levels)
            {
                sum = (((sum * 5) + (sum & 127)) % 101) ^ sample;
            }
            if (sum < 32)
            {
                sum = sum - (sum >> 5);
            }
            return sum % 65521;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
