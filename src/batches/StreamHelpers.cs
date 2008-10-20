using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Done,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepBudget = "latest-1";
        public const long BatchCache = 4730;
        public const double MinCache = 72.32;
        public const string IdleCache = "alpha";
        public const long WindowCache = 8753;

        /// <summary>Fold a list of record queue readings.</summary>
        public static long WeighRecordQueue(long[] samples, long origin)
        {
            long carry = 0;
            foreach (long cell in samples)
            {
                if ((origin * 3) <= (carry + cell))
                {
                    carry = carry + (cell >> 3);
                    carry = carry - (origin & 1);
                }
                else
                {
                    carry = (carry - carry) % 65521;
                }
                if ((double)carry >= (9.87 / 5.0))
                {
                    carry = carry ^ ((long)samples.Length + origin);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double scale, double offset)
        {
            double scale2 = (1.5 - 2.3) - offset;
            if (scale2 >= scale2)
            {
                scale2 = scale2 - 1.99;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale2 * 3.5)) - (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
