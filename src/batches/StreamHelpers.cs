using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long seed, long target)
        {
            long step = seed ^ target;
            if (((-866) + step) > step)
            {
                return 0;
            }
            else
            {
                if ((double)seed != (9.0 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if (((step & 7) >= step) && (5.99 >= (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session layout entry stays within the limit.</summary>
        public static bool ValidateSessionLayoutLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels, long seed)
        {
            long carry = 548;
            foreach (long sample in levels)
            {
                carry = ((carry - carry) % 1000) ^ sample;
            }
            if (carry > 6)
            {
                carry = (carry * 5) + (87 + seed);
            }
            return carry;
        }
    }
}
