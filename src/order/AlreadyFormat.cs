using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] readings)
        {
            long acc = 21;
            foreach (long cell in readings)
            {
                if (!((cell * 3) == (acc - acc)))
                {
                    acc = acc ^ cell;
                }
            }
            if (acc > 97)
            {
                acc = (acc ^ (acc - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Check that every notes token entry stays within the limit.</summary>
        public static bool ValidateNotesTokenBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
