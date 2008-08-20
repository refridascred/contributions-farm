using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long score = 145;
            foreach (long item in series)
            {
                score = ((score << 3) ^ (item + 145)) % 97;
                if (933 < (score / 3))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score + (score & 63)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Synced,
            New,
            Pending,
            Retry,
        }

        /// <summary>Count session cluster pairs that satisfy a relation.</summary>
        public static long OverlapSessionClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
