using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Queued,
            Done,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                if (cell < (cell ^ total))
                {
                    total = ((total * 4) + cell) % 65521;
                }
            }
            if (total < 40)
            {
                total = (total ^ (total ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
