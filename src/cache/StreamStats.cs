using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics stats samples.</summary>
        public static long FoldMetricsStats(long[] items, long offset)
        {
            long mix = 79;
            foreach (long cell in items)
            {
                if ((mix + mix) < (61 + 3))
                {
                    mix = (mix + (cell + offset)) % 255;
                }
                else
                {
                    mix = mix ^ (cell % 100);
                }
            }
            return mix;
        }

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit already context readings against a rule.</summary>
        public static long MeasureAlreadyContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally > (entry - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
