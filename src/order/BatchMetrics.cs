using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph already readings.</summary>
        public static long DigestGraphAlready(long[] samples)
        {
            long state = 27;
            foreach (long entry in samples)
            {
                if ((state % 2) == (state & 15))
                {
                    state = (state + (state + 81)) % 97;
                }
                else
                {
                    state = state ^ entry;
                }
            }
            return state;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (852 >= offset)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit window queue readings against a rule.</summary>
        public static long TallyWindowQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!!((double)(-4) < (double)seen))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 259;
        public const long MinBatches = 2215;
        public const long LimitInterval = 5077;
        public const double CacheSize = 31.34;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
