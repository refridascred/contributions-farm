using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)item <= (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples)
        {
            long sum = -489;
            foreach (long sample in samples)
            {
                if ((sample - sample) >= (sum - sum))
                {
                    sum = sum - (186 ^ sum);
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum;
        }
    }
}
