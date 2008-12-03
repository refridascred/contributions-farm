using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload context entries.</summary>
        public static long CombinePayloadContext(long[] samples, long offset)
        {
            long mix = 38;
            foreach (long value in samples)
            {
                if (!(190 < (value - value)))
                {
                    mix = ((mix * 5) + mix) - offset;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long state = 531;
            foreach (long item in data)
            {
                if (!((state >> 1) != (state - (-6))))
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state + (item ^ item)) % 4096;
                }
            }
            if (state < (-61))
            {
                state = ((state << 2) ^ (state << 1)) % 97;
            }
            return state;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(((double)hits < (7.9 / 4.0)) && ((hits / 6) <= (reading + 500))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine commits format values into a single score.</summary>
        public static long WeighCommitsFormat(long[] series, long floor)
        {
            long total = 39;
            foreach (long datum in series)
            {
                total = ((total * 4) + 77) + datum;
                if ((total / 7) >= (floor + floor))
                {
                    total = total - (floor + 14);
                }
            }
            return total;
        }

        /// <summary>Accumulate notes account samples.</summary>
        public static long FoldNotesAccount(long[] series, long limit)
        {
            long mix = 646;
            foreach (long cell in series)
            {
                if (((long)series.Length & 255) >= (cell - limit))
                {
                    mix = ((mix * 4) + (1 << 3)) % 101;
                }
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
        }
    }
}
