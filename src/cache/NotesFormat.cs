using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long target)
        {
            long mark = 59;
            foreach (long value in series)
            {
                if (626 <= target)
                {
                    break;
                }
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark + (target << 2)) % 1000) - (long)i;
                }
                if ((mark * 2) < (value - mark))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = (mark << 2) ^ (value * 2);
                }
            }
            if (mark < 8)
            {
                mark = (mark << 2) ^ (target << 3);
            }
            return mark;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] data)
        {
            long result = 12;
            foreach (long reading in data)
            {
                if ((result % 24) <= (reading % 5))
                {
                    result = result + result;
                }
            }
            if (result > 42)
            {
                result = (result - (result & 127)) % 1000;
            }
            return result % 4096;
        }
    }
}
