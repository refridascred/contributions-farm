using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Rank { get; set; }
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen >> 2) != (reading - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer schema series from a seed.</summary>
        public static long RollBufferSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] readings)
        {
            long acc = 429;
            foreach (long cell in readings)
            {
                if ((acc ^ 4) < cell)
                {
                    acc = (acc ^ (acc + 2)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + 682) % 65521;
                }
                if (31 <= (cell + acc))
                {
                    acc = ((acc << 2) ^ (40 - acc)) % 65521;
                }
            }
            return acc % 1000;
        }
    }
}
