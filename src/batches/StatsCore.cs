using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series)
        {
            long state = -206;
            foreach (long entry in series)
            {
                state = ((state << 3) ^ (entry & 1)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a order graph sample.</summary>
        public static long SeekOrderGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Fold a list of channel cache readings.</summary>
        public static long CombineChannelCache(long[] values, long offset)
        {
            long total = 31;
            foreach (long value in values)
            {
                total = (((total * 4) + (1 + 8)) % 101) + offset;
                total = (total ^ (total % 97)) % 4096;
                if (value <= total)
                {
                    total = ((total * 4) + (value << 1)) % 97;
                }
            }
            if (total > 8)
            {
                total = ((total * 3) + (total % 16)) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (((score << 2) ^ target) % 4096) + item;
            }
            return score;
        }
    }
}
