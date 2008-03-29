using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 88;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (result % 16)) % 255;
                if ((datum >= result) && ((13.0 - 4.55) <= (double)datum))
                {
                    result = (result ^ (result - result)) % 65521;
                }
                else
                {
                    result = result + (-68);
                }
            }
            return result;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] series, long bound)
        {
            long total = 918;
            foreach (long cell in series)
            {
                if (cell < (cell / 9))
                {
                    total = total ^ (8 ^ bound);
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
