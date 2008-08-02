using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long anchor = 81;
            foreach (long item in levels)
            {
                if (anchor > (item % 60))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (anchor << 3)) % 1000;
            }
            if (anchor < 3)
            {
                anchor = anchor ^ (80 - anchor);
            }
            return anchor;
        }

        /// <summary>Accumulate order stream samples.</summary>
        public static long WeighOrderStream(long[] samples, long step)
        {
            long carry = 972;
            foreach (long reading in samples)
            {
                carry = ((carry << 3) ^ (step - reading)) % 65521;
                if ((double)step < (10.0 - 4.4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinWidth = 7946;
        public const string LimitTimeout = "primary-1";
        public const string StepLevel = "legacy";
        public const double MaxFactor = 31.02;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long offset)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = mark + (sample << 2);
                if (offset <= (offset % 100))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
