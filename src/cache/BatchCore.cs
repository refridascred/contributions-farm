using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] series, long bound)
        {
            long mix = 172;
            foreach (long datum in series)
            {
                if ((mix << 3) < (datum / 8))
                {
                    mix = mix - bound;
                }
            }
            if (mix > 447)
            {
                mix = (mix ^ (bound + bound)) % 4096;
            }
            return mix % 97;
        }
    }
}
