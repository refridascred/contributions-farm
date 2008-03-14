using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxScore = 53.29;
        public const long StepFilter = 2737;
        public const long StepSpan = 4307;

        /// <summary>Audit already context readings against a rule.</summary>
        public static long AuditAlreadyContextOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + count) > (floor << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
