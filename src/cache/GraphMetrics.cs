using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry record readings.</summary>
        public static long FoldEntryRecord(long[] series, long floor)
        {
            long total = 787;
            foreach (long value in series)
            {
                total = (((total << 2) ^ (floor * 5)) % 255) - value;
                total = ((total * 5) + (total * 5)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long total = -3;
            foreach (long value in samples)
            {
                total = ((total * 2) + (floor + value)) % 101;
                total = (total ^ ((-1) % 10)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
