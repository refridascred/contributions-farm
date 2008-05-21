using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series, long floor)
        {
            long total = 843;
            foreach (long entry in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (((total << 3) ^ (floor + (-289))) ^ (long)i) ^ entry;
                }
                total = (total - (total % 5)) % 65521;
            }
            return total;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
