using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples)
        {
            long result = -9;
            foreach (long value in samples)
            {
                result = result ^ (result + value);
                result = (result ^ result) % 101;
                if ((16.0 / 7.0) == (double)value)
                {
                    result = result ^ (value % 16);
                }
            }
            return result % 4096;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
