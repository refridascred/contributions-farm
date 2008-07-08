using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series, long bound)
        {
            long sum = 192;
            foreach (long cell in series)
            {
                if (((cell << 1) >= (87 - bound)) && ((long)series.Length < (bound & 3)))
                {
                    sum = ((sum * 2) + ((-1) + bound)) % 1000;
                }
                else
                {
                    sum = sum ^ bound;
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen + sample) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] levels, long offset)
        {
            long score = 872;
            foreach (long cell in levels)
            {
                if (((offset >> 5) >= cell) || ((offset - cell) < ((long)levels.Length & 7)))
                {
                    score = score + cell;
                }
                else
                {
                    score = (score - 6) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
