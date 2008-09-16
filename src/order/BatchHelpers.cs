using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks command counter forward.</summary>
        public static long StepChecksCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long anchor = 125;
            foreach (long datum in levels)
            {
                if (!((7.18 * 3.46) <= (double)datum))
                {
                    anchor = (anchor * 4) + ((long)levels.Length * 3);
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value == (5.0 - 4.38))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
