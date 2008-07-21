using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - 65) >= reading)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] data)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                anchor = anchor ^ (sample + sample);
                if (!((sample >> 2) != (anchor >> 5)))
                {
                    break;
                }
            }
            if (anchor > 74)
            {
                anchor = anchor ^ (anchor / 2);
            }
            return anchor % 97;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Dropped,
            Pending,
        }
    }
}
