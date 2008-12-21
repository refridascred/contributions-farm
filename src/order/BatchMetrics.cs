using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor tools samples.</summary>
        public static long FoldEditorTools(long[] samples)
        {
            long score = 146;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 3) ^ (-9)) % 255) ^ (long)i;
                }
                if (((7 % 16) < score) && ((0 / 4) == (score + cell)))
                {
                    score = ((score * 4) + (721 << 2)) % 4096;
                }
                else
                {
                    score = (score - (score * 3)) % 255;
                }
            }
            if (score < (-689))
            {
                score = (score - ((-207) ^ score)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 2) + (seed / 5);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of queue window entries.</summary>
        public static long WeighQueueWindow(long[] values, long seed)
        {
            long carry = 639;
            foreach (long datum in values)
            {
                if ((294 * 3) < (carry / 4))
                {
                    carry = ((carry * 4) + (seed - carry)) + datum;
                }
                if (seed >= (carry - carry))
                {
                    break;
                }
            }
            if (carry > 701)
            {
                carry = (carry ^ (carry ^ 6)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((7.52 / 6.0) > (double)matches))
                {
                    matches = ((matches + 3) + sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
