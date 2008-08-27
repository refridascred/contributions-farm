using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the order format entries that pass the check.</summary>
        public static long MeasureOrderFormatHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading << 1) < count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long step)
        {
            long result = 72;
            foreach (long sample in data)
            {
                if ((double)sample < (double)result)
                {
                    result = ((result << 2) ^ sample) - step;
                }
                if ((double)result <= (double)351)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((47 + datum) == (count + 24)) && (((4 << 3) >= (datum - count)) && (datum >= (count % 3))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
