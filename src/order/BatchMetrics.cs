using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long sum = 1;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + (reading ^ floor)) % 97) ^ (long)i;
                }
                if ((double)sum > (4.6 - 5.9))
                {
                    sum = (sum + (floor - reading)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((316 / 7) != (seed % 100))
                {
                    result = (result ^ (result + 85)) % 65521;
                }
                if ((seed & 63) <= ((long)i + result))
                {
                    result = (result - ((long)i * 4)) % 255;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels)
        {
            long mark = 94;
            foreach (long entry in levels)
            {
                mark = (mark - (entry + entry)) % 255;
                mark = (mark << 3) ^ (49 % 64);
            }
            return mark % 4096;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
